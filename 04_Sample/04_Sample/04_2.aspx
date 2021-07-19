<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="04_2.aspx.cs" Inherits="_04_Sample._04_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" runat="server" Text="고객명"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbl2" runat="server" Text="결과" Width="400px" Height="100px" BackColor="#FF9999"></asp:Label>
        </div>
    </form>
</body>
</html>
