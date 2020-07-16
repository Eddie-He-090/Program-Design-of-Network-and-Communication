<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication2.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Login ID="Login1" runat="server" BackColor="#E3EAEB" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" DestinationPageUrl="~/WebForm1.aspx" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" LoginButtonText="Register" PasswordLabelText="Id:" TextLayout="TextOnTop" UserNameLabelText="Name:" OnAuthenticate="Login1_Authenticate" TitleText="学生离校登记">
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <LoginButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
                <TextBoxStyle Font-Size="0.8em" />
                <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            </asp:Login>
            Name:
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br/>
            Id:
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Redirect" />
        </div>
    </form>
</body>
</html>
