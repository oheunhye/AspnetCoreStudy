<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="04_1.aspx.cs" Inherits="_04_Sample._04_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" runat="server" Text="고객ID" BackColor="#CCFFFF"></asp:Label>
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl2" runat="server" Text="비밀번호" BackColor="#CCFFFF"></asp:Label>
            <asp:TextBox ID="txt2" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </form>
</body>
</html>
