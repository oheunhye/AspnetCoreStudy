<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userMain.aspx.cs" Inherits="_04_Sample.userMain" %>
<!-- 사용자 정의 컨트롤 사용 (TapPrefix:접두사역할) -->
<%@ Register Src="~/UserControl/userMsg.ascx" TagName="MsgTag" TagPrefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- css연결 -->
    <link href="~/css/Message.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <!-- 사용자 정의 컨트롤 연결 -->
        <uc1:MsgTag id="messageBox" runat="server" />

        <div>
            <asp:Label ID="Label1" runat="server" Text="주문수량 입력하세요"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="결과보기" />
        </div>
    </form>
</body>
</html>
