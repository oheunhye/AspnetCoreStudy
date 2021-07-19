<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="radioControl.aspx.cs" Inherits="_04_Sample.radioControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>한국어</asp:ListItem>
                <asp:ListItem>중국어</asp:ListItem>
                <asp:ListItem>영어</asp:ListItem>
                <asp:ListItem>스페인어</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="결과" />
            <br />
        </div>
    </form>
</body>
</html>
