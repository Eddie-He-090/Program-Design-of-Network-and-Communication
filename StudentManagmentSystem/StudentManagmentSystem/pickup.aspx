<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pickup.aspx.cs" Inherits="StudentManagmentSystem.pickup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>接送管理</title>
    <link href="css/StyleSheet1.css" rel="stylesheet" />
    <link href="css/StyleSheet2.css" rel="stylesheet" />
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
            <h1>学生接送信息管理
            </h1>
            <div>
                <div class="one_third_div">
                    <asp:Label ID="Label1" runat="server" Text="金牛路家长等待人数"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="one_third_div">
                    <asp:Label ID="Label3" runat="server" Text="在校学生人数"></asp:Label>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="one_third_div">
                    <asp:Label ID="Label5" runat="server" Text="向阳路家长等待人数"></asp:Label>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
            <div>
                <br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="学生到校登记" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="学生离校登记" />
                <br />
                接送地点：
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True" Value="CowRoad">金牛路路口</asp:ListItem>
                <asp:ListItem Value="SunRoad">向阳路路口</asp:ListItem>
                <asp:ListItem Value="0">取消</asp:ListItem>
            </asp:DropDownList>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="家长接送申请、修改、取消" />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
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
