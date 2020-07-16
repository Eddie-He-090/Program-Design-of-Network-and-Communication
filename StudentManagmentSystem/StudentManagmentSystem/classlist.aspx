﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="classlist.aspx.cs" Inherits="StudentManagmentSystem.classlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>班级管理</title>
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
            <h1>本班学生列表</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="班级："></asp:Label>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Stu_id" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                        <asp:BoundField DataField="Stu_id" HeaderText="Stu_id" InsertVisible="False" ReadOnly="True" SortExpression="Stu_id" />
                        <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                        <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                        <asp:BoundField DataField="Sex" HeaderText="Sex" SortExpression="Sex" />
                        <asp:BoundField DataField="Class" HeaderText="Class" SortExpression="Class" />
                        <asp:BoundField DataField="Position" HeaderText="Position" SortExpression="Position" />
                        <asp:BoundField DataField="Pick" HeaderText="Pick" SortExpression="Pick" />
                    </Columns>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbsmsConnectionString %>" DeleteCommand="DELETE FROM [stu_users] WHERE [Stu_id] = @Stu_id" InsertCommand="INSERT INTO [stu_users] ([UserName], [Password], [Name], [Sex], [Class], [Position], [Pick]) VALUES (@UserName, @Password, @Name, @Sex, @Class, @Position, @Pick)" SelectCommand="SELECT * FROM [stu_users] WHERE ([Class] = @Class)" UpdateCommand="UPDATE [stu_users] SET [UserName] = @UserName, [Password] = @Password, [Name] = @Name, [Sex] = @Sex, [Class] = @Class, [Position] = @Position, [Pick] = @Pick WHERE [Stu_id] = @Stu_id">
                    <DeleteParameters>
                        <asp:Parameter Name="Stu_id" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="UserName" Type="String" />
                        <asp:Parameter Name="Password" Type="String" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Sex" Type="String" />
                        <asp:Parameter Name="Class" Type="String" />
                        <asp:Parameter Name="Position" Type="String" />
                        <asp:Parameter Name="Pick" Type="String" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:SessionParameter Name="Class" SessionField="Class" Type="String" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="UserName" Type="String" />
                        <asp:Parameter Name="Password" Type="String" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Sex" Type="String" />
                        <asp:Parameter Name="Class" Type="String" />
                        <asp:Parameter Name="Position" Type="String" />
                        <asp:Parameter Name="Pick" Type="String" />
                        <asp:Parameter Name="Stu_id" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </div>
            <br />
        </div>
        <div id="footdiv" class="main">
            网站版权
        <br />
            梁志浩 何尔恒
        </div>
    </form>
</body>
</html>
