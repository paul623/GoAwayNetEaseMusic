using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DamnNetEase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LogAppend(Color.Green,"初始化中，当前工作路径：" + getCurPath());
            //tb_log.AppendText(getTime() + "初始化中，当前工作路径：" + getCurPath());
            String subPath = getCurPath() + "\\Download";
            if(!System.IO.Directory.Exists(subPath))
            {
                System.IO.Directory.CreateDirectory(subPath);
            }
            this.StartPosition = FormStartPosition.CenterScreen;//居中显示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_id.Text.Equals("")||tb_name.Text.Equals(""))
            {
                MessageBox.Show("ID或和名称不能为空，请点击解析后重试", "错误");
            }
            else
            {
                String url = "http://music.163.com/song/media/outer/url?id=";
                url = url + tb_id.Text + ".mp3";
                tb_log.AppendText(getTime() + url);
                String path = getCurPath() + "\\Download\\" + tb_name.Text + ".mp3";
                String result = HttpDownloadFile(url, path);
                LogAppend( Color.Green,"下载成功,路径：" + result);
            }
           
           
        }


        public static string HttpDownloadFile(string url, string path)
        {

            // 设置参数
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //发送请求并获取相应回应数据
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream responseStream = response.GetResponseStream();

            //创建本地文件写入流
            Stream stream = new FileStream(path, FileMode.Create);

            byte[] bArr = new byte[1024];
            int size = responseStream.Read(bArr, 0, (int)bArr.Length);
            while (size > 0)
            {
                stream.Write(bArr, 0, size);
                size = responseStream.Read(bArr, 0, (int)bArr.Length);
            }
            stream.Close();
            responseStream.Close();
            return path;
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            String input = tb_input.Text;
            if (input.Contains("="))
            {
                String str_id = input.Split('=')[1];
                if (str_id.Contains("&"))
                {
                    str_id = str_id.Split('&')[0];
                    tb_id.Text = str_id;
                    LogAppend(Color.Green, "解析成功，请输入文件名并点击下载按钮开始下载");
                }
                else
                {
                    //tb_log.AppendText(getTime()+"解析失败,请检查");
                    LogAppend(Color.Red, "解析失败,请检查" );
                }
            }
            else
            {
                LogAppend(Color.Red, "解析失败,请检查");
            }

        }
        public static String getTime()
        {
            return "\r\n"+DateTime.Now.ToString() + "\r\n";
        }

        public static String getCurPath()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String path =getCurPath()+ "\\lib\\DesktopTool.exe";
            try
            {
                MessageBox.Show("直接拖拽ncm格式文件即可，生成路径在:" + getCurPath() + "下", "温馨提示");
                System.Diagnostics.Process.Start(path);
            }
            catch
            {
                MessageBox.Show("系统资源损坏，请重新安装", "警告");
            }
               
           
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("在某云中选择要下载的歌曲，选择分享，复制链接到解析窗口。点击解析按钮，检查id是否解析正确，并为其命名，然后点击下载即可。", "使用教程");
        }

        private void 免责说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本软件仅供个人学习使用，请勿用作任何盈利非法用途", "声明");
        }

        private void 开源库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本项目ncm格式转换基于开源库：https://github.com/anonymous5l/ncmdump", "开源声明");

        }

        private void 关于我ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Powered By Paul623"+ "\r\n"+"走开，网易云 v1.00", "关于");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process open = new System.Diagnostics.Process();
            open.StartInfo.UseShellExecute = true;
            open.StartInfo.FileName = getCurPath()+"\\Download";
            open.Start();
        }

        public void LogAppend(Color color, string text)
        {
            tb_log.SelectionColor = Color.Blue;
            tb_log.AppendText(getTime());
            tb_log.SelectionColor = color;
            tb_log.AppendText(text);
            tb_log.SelectionStart = tb_log.Text.Length;
            tb_log.ScrollToCaret();
        }

        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String url = "https://github.com/paul623/GoAwayNetEaseMusic";
            System.Diagnostics.Process.Start("iexplore.exe", url);
        }

        private void 日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String updateLog = "1.新增打开文件入口\r\n2.新增ncm格式文件转换支持\r\n3.优化日志显示效果";
            MessageBox.Show(updateLog, "v1.0.0更新日志");
        }
    }
   
}
