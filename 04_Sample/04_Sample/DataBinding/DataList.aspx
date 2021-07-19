<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="_04_Sample.DataBinding.DataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" SelectCommand="SELECT * FROM [board]"></asp:SqlDataSource>
            <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataKeyField="no" DataSourceID="SqlDataSource1" ForeColor="#333333">
                <AlternatingItemStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#9999FF" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="White" />
                <HeaderTemplate>
                    문의 게시판<br />
                </HeaderTemplate>
                <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <ItemTemplate>
                    no:
                    <asp:Label ID="noLabel" runat="server" Text='<%# Eval("no") %>' />
                    <br />
                    irum:
                    <asp:Label ID="irumLabel" runat="server" Text='<%# Eval("irum") %>' />
                    <br />
                    email:
                    <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
                    <br />
                    title:
                    <asp:Label ID="titleLabel" runat="server" Text='<%# Eval("title") %>' />
                    <br />
                    subcontent:
                    <asp:Label ID="subcontentLabel" runat="server" Text='<%# Eval("subcontent") %>' />
                    <br />
                    pwd:
                    <asp:Label ID="pwdLabel" runat="server" Text='<%# Eval("pwd") %>' />
                    <br />
                    regdate:
                    <asp:Label ID="regdateLabel" runat="server" Text='<%# Eval("regdate") %>' />
                    <br />
                    hits:
                    <asp:Label ID="hitsLabel" runat="server" Text='<%# Eval("hits") %>' />
                    <br />
<br />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            </asp:DataList>
        </div>
    </form>
</body>
</html>
