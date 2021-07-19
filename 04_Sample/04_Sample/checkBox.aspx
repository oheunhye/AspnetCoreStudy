<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkBox.aspx.cs" Inherits="_04_Sample.checkBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="관심항목를 선택하세요"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="확인" OnClick="Button1_Click" />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="화장품/잡화" />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="캐주얼의류" />
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="아웃도어 상품" />
            <br />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="침구/인테리어" />
            <br />
            <asp:CheckBox ID="CheckBox5" runat="server" Text="식품" />
            <br />

            <asp:Label ID="lbl결과" runat="server" Text="결과"></asp:Label>
        </div>
    </form>
</body>
</html>
