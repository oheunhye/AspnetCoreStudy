<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBind.aspx.cs" Inherits="_04_Sample.DataBinding.DataBind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" DeleteCommand="DELETE FROM [board] WHERE [no] = @no" InsertCommand="INSERT INTO [board] ([irum], [title], [regdate], [hits]) VALUES (@irum, @title, @regdate, @hits)" SelectCommand="SELECT [no], [irum], [title], [regdate], [hits] FROM [board] ORDER BY [no] DESC" UpdateCommand="UPDATE [board] SET [irum] = @irum, [title] = @title, [regdate] = @regdate, [hits] = @hits WHERE [no] = @no">
                <DeleteParameters>
                    <asp:Parameter Name="no" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="irum" Type="String" />
                    <asp:Parameter Name="title" Type="String" />
                    <asp:Parameter Name="regdate" Type="DateTime" />
                    <asp:Parameter Name="hits" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="irum" Type="String" />
                    <asp:Parameter Name="title" Type="String" />
                    <asp:Parameter Name="regdate" Type="DateTime" />
                    <asp:Parameter Name="hits" Type="Int32" />
                    <asp:Parameter Name="no" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="no" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="no" HeaderText="no" InsertVisible="False" ReadOnly="True" SortExpression="no" />
                    <asp:BoundField DataField="irum" HeaderText="irum" SortExpression="irum" />
                    <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                    <asp:BoundField DataField="regdate" HeaderText="regdate" SortExpression="regdate" />
                    <asp:BoundField DataField="hits" HeaderText="hits" SortExpression="hits" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
