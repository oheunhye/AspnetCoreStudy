<!-- CodeBehind:숨김파일,연결된 백엔드코드(단일페이지에선 필요없음) Inherits:프로젝트이름.파일이름(class) -->
<%@ Page Language="C#" AutoEventWireup="true" Inherits="_04_Sample.PageClass.pageclassInstance" %>
<!DOCTYPE html>

<!-- 단일 페이지 이벤트사용 -->
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToString("yyyy-MM-dd");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="결과보기" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
