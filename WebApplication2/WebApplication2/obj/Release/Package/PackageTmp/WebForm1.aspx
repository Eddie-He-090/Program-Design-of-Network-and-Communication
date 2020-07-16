<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>
<link href="Content/StyleSheet1.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生接送信息收集系统</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="one_third_div">
                <asp:Label ID="Label1" runat="server" Text="金牛路家长等待人数"></asp:Label>
                <br/>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>

            <div class="one_third_div">
                <asp:Label ID="Label3" runat="server" Text="在校学生人数"></asp:Label>
                <br/>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </div>

            <div class="one_third_div">
                <asp:Label ID="Label5" runat="server" Text="向阳路家长等待人数"></asp:Label>
                <br/>
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="学生到校登记" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="家长接送申请、修改、取消" />
        <br />
        <asp:Button ID="Button4" runat="server" Text="学生离校登记" OnClick="Button4_Click" />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="GridView" />
    </form>
</body>
</html>
