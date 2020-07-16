<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" LoginButtonText="Apply" PasswordLabelText="Id:" TitleText="家长接送申请" UserNameLabelText="Name:" DestinationPageUrl="~/WebForm1.aspx" OnAuthenticate="Login1_Authenticate">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
        接送地点：<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True" Value="CowRoad">金牛路路口</asp:ListItem>
            <asp:ListItem Value="SunRoad">向阳路路口</asp:ListItem>
            <asp:ListItem Value="0">取消</asp:ListItem>
        </asp:DropDownList>
        <br />
        Name:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        Id:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Redirect" />
    </form>
</body>
</html>
