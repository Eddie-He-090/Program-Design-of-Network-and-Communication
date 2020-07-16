<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="StudentManagmentSystem._default" %>

<link href="css/StyleSheet2.css" rel="stylesheet" />
<link href="css/StyleSheet1.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>学生接送信息收集系统</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="headdiv" class="main">
            <ul class="nav">
                <li>
                    <a href="#">首页</a>
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
                    <%--<asp:Panel ID="Panel6" runat="server">--%>
                    <a href="Download.aspx" target="_blank">Form应用下载</a>
                    <%--</asp:Panel>--%>
                </li>
                <li>
                    <%--<asp:Panel ID="Panel4" runat="server">--%>
                    <a href="Chatbot.aspx" target="_blank">聊天机器人</a>
                    <%--</asp:Panel>--%>
                </li>
                <li class="dropdown">
                    <%--<asp:Panel ID="Panel5" class="dropdown" runat="server">--%>
                    <%-- <a href="#" class="dropbtn">地图API</a> --%>
                    <a href="#">地图API</a>
                    <div class="dropdown-content">
                        <a href="HtmlPage1.html" target="_blank">IP定位</a>
                        <a href="HtmlPage2.html" target="_blank">下属行政区查询</a>
                        <%--<a href="#" target="_blank">链接 3</a>--%>
                    </div>
                    <%--</asp:Panel>--%>
                </li>
                <li class="logininfo">
                    <asp:LoginStatus ID="LoginStatus1" class="login" runat="server" OnLoggedOut="LoginStatus1_LoggedOut" />
                </li>
                <li class="logininfo">
                    <asp:LoginName ID="LoginName1" class="login" runat="server" FormatString="{0}，你好" />
                </li>
            </ul>
            <%--
            <asp:Menu ID="MenuTest" runat="server" EnableTheming="True" Orientation="Horizontal"></asp:Menu>--%>
        </div>
        <div id="bodydiv" class="main">
            <h1>欢迎使用学生接送信息收集系统
            </h1>
            <div class="content_1of2">
                <h2>公 告</h2>
                <ul>
                    <li>我是公告我是公告我是公告我是公告我是公告1<span>[2020-05-05]</span></li>
                    <li>我是公告我是公告我是公告我是公告我是公告2<span>[2020-05-05]</span></li>
                    <li>我是公告我是公告我是公告我是公告我是公告3<span>[2020-05-05]</span></li>
                    <li>我是公告我是公告我是公告我是公告我是公告4<span>[2020-05-05]</span></li>
                    <li>我是公告我是公告我是公告我是公告我是公告5<span>[2020-05-05]</span></li>
                    <li>我是公告我是公告我是公告我是公告我是公告6<span>[2020-05-05]</span></li>
                    <li>我是公告我是公告我是公告我是公告我是公告7<span>[2020-05-05]</span></li>
                    <li>我是公告我是公告我是公告我是公告我是公告8<span>[2020-05-05]</span></li>
                    <li>我是公告我是公告我是公告我是公告我是公告9<span>[2020-05-05]</span></li>
                </ul>
            </div>
            <div class="content_1of2">
                <h2>通 知</h2>
                <ul>
                    <li>我是通知我是通知我是通知我是通知我是通知1<span>[2020-05-05]</span></li>
                    <li>我是通知我是通知我是通知我是通知我是通知2<span>[2020-05-05]</span></li>
                    <li>我是通知我是通知我是通知我是通知我是通知3<span>[2020-05-05]</span></li>
                    <li>我是通知我是通知我是通知我是通知我是通知4<span>[2020-05-05]</span></li>
                    <li>我是通知我是通知我是通知我是通知我是通知5<span>[2020-05-05]</span></li>
                    <li>我是通知我是通知我是通知我是通知我是通知6<span>[2020-05-05]</span></li>
                    <li>我是通知我是通知我是通知我是通知我是通知7<span>[2020-05-05]</span></li>
                    <li>我是通知我是通知我是通知我是通知我是通知8<span>[2020-05-05]</span></li>
                    <li>我是通知我是通知我是通知我是通知我是通知9<span>[2020-05-05]</span></li>
                </ul>
            </div>
            <div>&nbsp;</div>
        </div>
        <div id="footdiv" class="main">
            网站版权
        <br />
            梁志浩 何尔恒
        </div>
    </form>
</body>
</html>
