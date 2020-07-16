<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chatbot.aspx.cs" Inherits="StudentManagmentSystem.Chatbot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>聊天机器人</title>
    <link href="css/StyleSheet1.css" rel="stylesheet"/>
</head>
<body>
<form id="form1" runat="server">
    <div id="loginblock">
        <h1>
            聊天机器人
        </h1>
        <asp:TextBox ID="TextBox1" runat="server" Height="36px" TextMode="Search" Width="400px" Font-Size="Medium" ToolTip="输入框"></asp:TextBox>
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发送" Height="36px"/>
        <br/>
        <br/>
        <asp:TextBox ID="TextBox2" runat="server" Height="155px" TextMode="MultiLine" Width="600px" ReadOnly="True" Font-Size="X-Large" ToolTip="结果框"></asp:TextBox>
    </div>
    <br />
    <div class="content_1of2">
        <ul style="padding: 0px; margin: 0px;border: 1px solid rgb(232, 232, 232); box-sizing: border-box; width: 100%; overflow: hidden; color: rgb(51, 51, 51); font-size: 14px; font-weight: 400; orphans: 2; widows: 2; background-color: rgb(255, 255, 255);">
            <li style="height: 36px; line-height: 36px; text-align: center">天气：天气深圳</li>
            <li style="height: 36px; line-height: 36px; text-align: center">智能聊天：你好</li>
            <li style="height: 36px; line-height: 36px; text-align: center">歌词⑴：歌词后来</li>
            <li style="height: 36px; line-height: 36px; text-align: center">计算⑴：计算1+1*2/3-4</li>
            <li style="height: 36px; line-height: 36px; text-align: center">ＩＰ⑴：归属127.0.0.1</li>
            <li style="height: 36px; line-height: 36px; text-align: center">手机⑴：归属13430108888</li>
            <li style="height: 36px; line-height: 36px; text-align: center">成语查询：成语一生一世</li>
        </ul>
    </div>
    <div class="content_1of2">
        <ul style="padding: 0px; margin: 0px; border: 1px solid rgb(232, 232, 232); box-sizing: border-box; width: 100%; overflow: hidden; color: rgb(51, 51, 51); font-size: 14px; font-weight: 400; orphans: 2; text-align: start; widows: 2; background-color: rgb(255, 255, 255);">
            <li style="height: 36px; line-height: 36px; text-align: center">中英翻译：翻译i love you</li>
            <li style="height: 36px; line-height: 36px; text-align: center">笑话：笑话</li>
            <li style="height: 36px; line-height: 36px; text-align: center">歌词⑵：歌词后来-刘若英</li>
            <li style="height: 36px; line-height: 36px; text-align: center">计算⑵：1+1*2/3-4</li>
            <li style="height: 36px; line-height: 36px; text-align: center">ＩＰ⑵：127.0.0.1</li>
            <li style="height: 36px; line-height: 36px; text-align: center">手机⑵：13430108888</li>
            <li style="height: 36px; line-height: 36px; text-align: center">五笔/拼音：好字的五笔/拼音</li>
        </ul>
    </div>
</form>
</body>
</html>