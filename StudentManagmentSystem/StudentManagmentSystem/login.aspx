<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="StudentManagmentSystem.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>本地登录</title>
    <link href="css/StyleSheet1.css" rel="stylesheet"/>
</head>
<body>
<form id="form1" runat="server">
    <div id="headdiv" class="main">
        <ul class="nav">
            <li>
                <a href="default.aspx">返回首页</a>
            </li>
        </ul>
    </div>
    <div id="bodydiv" class="main">
        <div class="login">
            <h1>
                登录
            </h1>
            <div id="loginblock">
                身份选择：<asp:RadioButton ID="RadioButton1" runat="server" Checked="True" GroupName="Login Identity" Text="家长"/>
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Login Identity" Text="教师"/>
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Login Identity" Text="管理员"/>
                <br/>
                用户名：<asp:TextBox ID="TextBox1" runat="server" Wrap="False" Width="180px"></asp:TextBox>
                <br/>
                密 码：<asp:TextBox ID="TextBox2" runat="server" Wrap="False" TextMode="Password" Width="180px"></asp:TextBox>
                <br/>
                <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" style="width: 40px"/>
                <br/>
                <asp:Label ID="Label1" runat="server" Text=" " ForeColor="Red"></asp:Label>
            </div>
        </div>

    </div>
    <div id="footdiv" class="main">
        网站版权
        <br/>
        梁志浩 何尔恒
    </div>
</form>
</body>
</html>