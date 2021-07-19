<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imageBtn.aspx.cs" Inherits="_04_Sample.imageBtn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="imgbtn" runat="server" AlternateText="healthpiaLogo" ImageUrl="~/Img/img_1.jpg" OnClick="imgbtn_Click" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
