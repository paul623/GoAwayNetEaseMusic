namespace DamnNetEase
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_init = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.免责说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开源库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_log = new System.Windows.Forms.RichTextBox();
            this.更新日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 348);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(226, 35);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "开始下载";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_input);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "解析框";
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(7, 25);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(212, 110);
            this.tb_input.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_init);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_id);
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 157);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "解析结果";
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(11, 102);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(208, 33);
            this.btn_init.TabIndex = 4;
            this.btn_init.Text = "解析";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "歌曲ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(81, 57);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(132, 25);
            this.tb_id.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(81, 25);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(132, 25);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "歌曲名称";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_log);
            this.groupBox3.Location = new System.Drawing.Point(255, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 305);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日志";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "ncm格式转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paul 2020.5.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用说明ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.更新日志ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.免责说明ToolStripMenuItem,
            this.开源库ToolStripMenuItem,
            this.关于我ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 免责说明ToolStripMenuItem
            // 
            this.免责说明ToolStripMenuItem.Name = "免责说明ToolStripMenuItem";
            this.免责说明ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.免责说明ToolStripMenuItem.Text = "免责说明";
            this.免责说明ToolStripMenuItem.Click += new System.EventHandler(this.免责说明ToolStripMenuItem_Click);
            // 
            // 开源库ToolStripMenuItem
            // 
            this.开源库ToolStripMenuItem.Name = "开源库ToolStripMenuItem";
            this.开源库ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.开源库ToolStripMenuItem.Text = "开源库";
            this.开源库ToolStripMenuItem.Click += new System.EventHandler(this.开源库ToolStripMenuItem_Click);
            // 
            // 关于我ToolStripMenuItem
            // 
            this.关于我ToolStripMenuItem.Name = "关于我ToolStripMenuItem";
            this.关于我ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.关于我ToolStripMenuItem.Text = "关于我";
            this.关于我ToolStripMenuItem.Click += new System.EventHandler(this.关于我ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "打开下载路径";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(7, 25);
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tb_log.Size = new System.Drawing.Size(294, 274);
            this.tb_log.TabIndex = 0;
            this.tb_log.Text = "";
            // 
            // 更新日志ToolStripMenuItem
            // 
            this.更新日志ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日志ToolStripMenuItem,
            this.检查更新ToolStripMenuItem});
            this.更新日志ToolStripMenuItem.Name = "更新日志ToolStripMenuItem";
            this.更新日志ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.更新日志ToolStripMenuItem.Text = "更新日志";
            // 
            // 日志ToolStripMenuItem
            // 
            this.日志ToolStripMenuItem.Name = "日志ToolStripMenuItem";
            this.日志ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.日志ToolStripMenuItem.Text = "日志";
            this.日志ToolStripMenuItem.Click += new System.EventHandler(this.日志ToolStripMenuItem_Click);
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.检查更新ToolStripMenuItem.Text = "检查更新";
            this.检查更新ToolStripMenuItem.Click += new System.EventHandler(this.检查更新ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "你走，网易云";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 免责说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开源库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox tb_log;
        private System.Windows.Forms.ToolStripMenuItem 更新日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
    }
}

