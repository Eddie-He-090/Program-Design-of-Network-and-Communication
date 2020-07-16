<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Download.aspx.cs" Inherits="StudentManagmentSystem.Download" %>

<!DOCTYPE html>
<link href="css/StyleSheet1Copy.css" rel="stylesheet" />
<link href="css/StyleSheet2.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Form应用下载</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="headdiv" class="main">
            <ul class="nav">
                <li>
                    <a href="default.aspx">首页</a>
                </li>
                <li>
                    <asp:Panel ID="Panel1" runat="server">
                        <a href="pers_info_stu.aspx">个人信息</a>
                    </asp:Panel>
                </li>
                <li>
                    <a href="pickup.aspx">接送管理</a>
                </li>
                <li>
                    <asp:Panel ID="Panel2" runat="server">
                        <a href="classlist.aspx">班级管理</a>
                    </asp:Panel>
                </li>
                <li>
                    <asp:Panel ID="Panel3" runat="server">
                        <a href="userlist.aspx">用户管理</a>
                    </asp:Panel>
                </li>
                <li>
                    <a href="Download.aspx" target="_blank">Form应用下载</a>
                </li>
                <li>
                    <a href="Chatbot.aspx" target="_blank">聊天机器人</a>
                </li>
                <li class="dropdown">
                    <a href="#">地图API</a>
                    <div class="dropdown-content">
                        <a href="HtmlPage1.html" target="_blank">IP定位</a>
                        <a href="HtmlPage2.html" target="_blank">下属行政区查询</a>
                    </div>
                </li>
                <li class="logininfo">
                    <asp:LoginStatus ID="LoginStatus1" runat="server" OnLoggedOut="LoginStatus1_LoggedOut" />
                </li>
                <li class="logininfo">
                    <asp:LoginName ID="LoginName1" class="login" runat="server" FormatString="{0}，你好" />
                </li>
            </ul>
        </div>
        <div id="bodydiv" class="main">
            <h1>
                欢迎访问Form应用下载页
            </h1>
            <p class="alart">
                下载时可能会提示“文件已被阻止，因为它可能危害你的设备。”<br />
                但请放心下载体验，只是应用未加发布者签名，应用是安全的。
            </p>
            <div class="content_1of2">
                <h2>何尔恒的Form应用</h2>
                <ul>
                    <li><a href="HEH_Handler\Handler1.ashx">编解码及身份证出生年月日提取程序</a><span>[2020-05-05]</span></li>
                    <li><a href="HEH_Handler\Handler2.ashx">简易计算器</a><span>[2020-05-05]</span></li>
                    <li><a href="HEH_Handler\Handler3.ashx">长短按加减计数程序</a><span>[2020-05-05]</span></li>
                    <li><a href="HEH_Handler\Handler4.ashx">安卓ADB调试程序</a><span>[2020-05-05]</span></li>
                    <li><a href="HEH_Handler\Handler5.ashx">文件HASH值计算程序</a><span>[2020-05-05]</span></li>
                    <li><a href="HEH_Handler\Handler6.ashx">邮件群发程序</a><span>[2020-05-05]</span></li>
                </ul>
            </div>
            <div class="content_1of2">
                <h2>梁志浩的Form应用</h2>
                <ul>
                    <li><a href="LZH_Handler/Calculators.ashx">计算器</a><span>[2020-03-12]</span></li>
                    <li><a href="LZH_Handler/dialog.ashx">有趣的窗口程序</a><span>[2020-03-11]</span></li>
                    <li><a href="LZH_Handler/StringCoding.ashx">字符编码转换器</a><span>[2020-03-24]</span></li>
                    <li><a href="LZH_Handler/WebBrowser.ashx">自制浏览器</a><span>[2020-05-20]</span></li>
                    <li><a href="LZH_Handler/SlidingWindow.ashx">TCP滑动窗口协议演示程序</a><span>[2020-05-19]</span></li>
                    <li>&nbsp;&nbsp;&nbsp;</li>
                </ul>
            </div>
            <div>&nbsp;</div>
        </div>
        <div id="footdiv" class="main">
            网站版权
            <br/>
            梁志浩 何尔恒
        </div>
    </form>
</body>
</html>
