<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="04_3.aspx.cs" Inherits="_04_Sample._05_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn" runat="server" Text="현재시간" OnClick="btn_Click" />
        </div>
    </form>
</body>
</html>
