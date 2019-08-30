studygolang：[https://github.com/studygolang/studygolang](https://github.com/studygolang/studygolang)
===========
[![Build Status](https://travis-ci.org/studygolang/studygolang.svg?branch=master)](https://travis-ci.org/studygolang/studygolang)

[Go语言中文网 - Golang中文社区](https://studygolang.com "Go语言中文网 - Golang中文社区") 源码

目前在线运行的是 Master。欢迎有兴趣的 gopher 们参与进来，一起构建一个完善的 Go 语言中文网，Go 语言爱好者的学习家园，参与方式请参考：https://studygolang.com/topics/4092

# 本地搭建一个 Go语言中文网 #

## 步骤一

首先你都需要下载代码，因为代码中有很多静态资源。可以[点击这里下载](https://github.com/studygolang/studygolang/archive/master.zip) 或 `git clone https://github.com/studygolang/studygolang` 下载。

## 步骤二

### 方式一：二进制安装（不推荐，可能不是最新的）

1、下载预编译好的二进制文件（将下载的文件放入源码的bin目录下，自己创建好bin目录）

<table class="table table-bordered table-striped table-condensed">
   <tr>
      <th>操作系统</th>
      <th>架构</th>
      <th>下载链接</th>
      <th>MD5SUM</th>
   </tr>
   <tr>
      <td>Linux</td>
      <td>amd64</td>
      <td><a href="http://pan.baidu.com/s/1i52MPUX#path=%252Fshare%252Fstudygolang%252F2.0%252Flinux" target="_blank">下载地址</a></td>
      <td>2f24752d2b382b218c50b8f64fb3ad2e</td>
   </tr>
   <tr>
      <td>OS X</td>
      <td>amd64</td>
      <td><a href="http://pan.baidu.com/s/1i52MPUX#path=%252Fshare%252Fstudygolang%252F2.0%252Fdarwin" target="_blank">下载地址</a></td>
      <td>2adab465eceab2ff89d23c21ffaafcaf</td>
   </tr>
   <tr>
      <td>Windows</td>
      <td>amd64</td>
      <td><a href="http://pan.baidu.com/s/1i52MPUX#path=%252Fshare%252Fstudygolang%252F2.0%252Fwindows%252Famd64" target="_blank">下载地址</a></td>
      <td>9d261afb56c3989fe67238fe8a09abf8</td>
   </tr>
   <tr>
      <td>Windows</td>
      <td>386</td>
      <td><a href="http://pan.baidu.com/s/1i52MPUX#path=%252Fshare%252Fstudygolang%252F2.0%252Fwindows%252F386" target="_blank">下载地址</a></td>
      <td>1723fbc4f2c841e1f45b303df8a0dc0f</td>
   </tr>
</table>

### 方式二：源码安装（推荐）

要求 Go 1.8+

1、下载 gvt 依赖管理工具

	go get github.com/polaris1119/gvt

下载后将 gvt 加入 PATH 中。

2、下载安装依赖

cd 到 studygolang 源码目录

	// unix
	./getpkg.sh
	// windows
	getpkg.bat

3、编译 studygolang

	// unix
	./install.sh
	// windows
	install.bat

这样便编译好了 studygolang

### 方式三：go run（不推荐）

要求 Go 1.8+

1、下载 gvt 依赖管理工具

	go get github.com/polaris1119/gvt

下载后将 gvt 加入 PATH 中。

2、下载安装依赖

cd 到 studygolang 源码目录

	// unix
	./getpkg.sh

3、启动studygolang，不需要步骤三

    // unix
	./run.sh

## 步骤三

在 studygolang 源码中的 bin 目录下应该有了 studygolang 可执行文件。

接下来启动 studygolang。

	// unix
	./start.sh
	// windows
	start.bat

或者

	// unix
	bin/studygolang
	// windows
	bin\studygolang.exe

一切顺利的话，studygolang 应该就启动了。

## 步骤四

在浏览器中输入：http://127.0.0.1:8088

应该就能看到了。

接下来你会看到图形化安装界面，一步步照做吧。

* 如果之后有出现页面空白，请查看 error.log 是否有错误



# 使用该项目搭建的网站

- [Go语言中文网](https://studygolang.com)
- [Kotlin中国](https://kotlintc.com)