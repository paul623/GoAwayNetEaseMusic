# GoAwayNetEaseMusic
 你走，网易云

有时候剪辑需要一个配乐，但是都要vip了、、、、

emmmm可以通过外链的形式把这个mp3获取到（毕竟音质啥的就不在乎了）

所以就写了这个小程序，方便一点。基于netframework

另外把ncm转换的程序整合进来了





请勿用作任何非法用途

### 更新日志

v1.0.0

- 1.新增打开文件入口

- 2.新增ncm格式文件转换支持

- 3.优化日志显示效果

## 原理说明

接口：

```java
http://music.163.com/song/media/outer/url?id=xxx.mp3
```

用户只需要分享一首歌，如

```java
http://music.163.com/song?id=1305174455&userid=353005942
```

即可获取该歌曲的id，拼接即可得到歌曲直链：

```java
http://music.163.com/song/media/outer/url?id=1305174455.mp3
```



ncm格式转换直接参考：

[ncmdump](https://github.com/anonymous5l/ncmdump)