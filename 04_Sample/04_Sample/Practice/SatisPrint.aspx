<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SatisPrint.aspx.cs" Inherits="_04_Sample.Practice.SatisPrint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>설문지 조사</title>
    <link href="~/css/StyleSheet1.css" rel="stylesheet" type="text/css"/>
    <script language="javascript" type="text/javascript">
        //유효성 검사
        function CheckID(source, arg)
        {
            var idBank = new Array("momo12", "az1198", "grigo30", "hahaha20");
            for (var i = 0; i < idBank.length; i++) {
                arg.IsValid = (arg.Value == idBank[i]);
                if (arg.IsValid)
                {
                    break;
                }
            }
        }
    </script>
</head>
<body>
    <h1>고객 서비스 만족도 설문조사</h1>
    <hr />
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" class="lbl" runat="server" Text="아이디"></asp:Label>
            <asp:TextBox ID="txtID" CssClass="content1" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtID" ErrorMessage="아이디가 존재하지 않습니다." ClientValidationFunction="CheckID"></asp:CustomValidator>
            <br />
            <asp:Label ID="Label2" class="lbl" runat="server" Text="이메일"></asp:Label>
            <asp:TextBox ID="txtEmail" CssClass="content1" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="올바른 이메일 형식이 아닙니다." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label3" class="lbl" runat="server" Text="관심항목"></asp:Label>
            <br />
            <asp:CheckBoxList ID="chkList1" CssClass="content2" runat="server">
                <asp:ListItem>농수산물</asp:ListItem>
                <asp:ListItem>신선식품</asp:ListItem>
                <asp:ListItem>유가공식품</asp:ListItem>
                <asp:ListItem>유기농식품</asp:ListItem>
                <asp:ListItem>가공식품</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="Label4" class="lbl" runat="server" Text="개선점"></asp:Label>
            <asp:TextBox ID="txtMore" CssClass="content1" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="완료" />
            <br />
        </div>
    </form>
</body>
</html>
