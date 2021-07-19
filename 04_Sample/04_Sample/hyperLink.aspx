<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hyperLink.aspx.cs" Inherits="_04_Sample.hyperLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com">구글 바로가기</asp:HyperLink>
        </div>
        <div>
            <asp:HyperLink ID="HyperLink2" runat="server" ImageHeight="200px" ImageUrl="~/Img/img_2.jpg" NavigateUrl="https://www.naver.com"></asp:HyperLink>
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">바로가기</asp:LinkButton>
    </form>
</body>
</html>
