<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileRead.aspx.cs" Inherits="_04_Sample.File.File" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="파일읽어오기" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Rows="6" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
</body>
</html>
