<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listboxcontrol.aspx.cs" Inherits="_04_Sample.Listboxcontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 21px" Text="결과" /><br />
            <asp:ListBox ID="ListBox1" runat="server"  SelectionMode="Multiple">
                <asp:ListItem>잡화</asp:ListItem>
                <asp:ListItem>의류</asp:ListItem>
                <asp:ListItem>아웃도어</asp:ListItem>
                <asp:ListItem>인테리어</asp:ListItem>
            </asp:ListBox>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="결과"></asp:Label>
        </div>
    </form>
</body>
</html>
