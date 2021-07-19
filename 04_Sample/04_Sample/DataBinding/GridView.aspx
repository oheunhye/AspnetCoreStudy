<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="_04_Sample.DataBinding.GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" 
                ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" 
                DeleteCommand="DELETE FROM [board] WHERE [no] = @original_no AND (([irum] = @original_irum) OR ([irum] IS NULL AND @original_irum IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND (([title] = @original_title) OR ([title] IS NULL AND @original_title IS NULL)) AND (([subcontent] = @original_subcontent) OR ([subcontent] IS NULL AND @original_subcontent IS NULL)) AND (([pwd] = @original_pwd) OR ([pwd] IS NULL AND @original_pwd IS NULL)) AND (([regdate] = @original_regdate) OR ([regdate] IS NULL AND @original_regdate IS NULL)) AND (([hits] = @original_hits) OR ([hits] IS NULL AND @original_hits IS NULL))" 
                InsertCommand="INSERT INTO [board] ([irum], [email], [title], [subcontent], [pwd], [regdate], [hits]) VALUES (@irum, @email, @title, @subcontent, @pwd, @regdate, @hits)" 
                OldValuesParameterFormatString="original_{0}" 
                SelectCommand="SELECT * FROM [board]" 
                UpdateCommand="UPDATE [board] SET [irum] = @irum, [email] = @email, [title] = @title, [subcontent] = @subcontent, [pwd] = @pwd, [regdate] = @regdate, [hits] = @hits WHERE [no] = @original_no AND (([irum] = @original_irum) OR ([irum] IS NULL AND @original_irum IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND (([title] = @original_title) OR ([title] IS NULL AND @original_title IS NULL)) AND (([subcontent] = @original_subcontent) OR ([subcontent] IS NULL AND @original_subcontent IS NULL)) AND (([pwd] = @original_pwd) OR ([pwd] IS NULL AND @original_pwd IS NULL)) AND (([regdate] = @original_regdate) OR ([regdate] IS NULL AND @original_regdate IS NULL)) AND (([hits] = @original_hits) OR ([hits] IS NULL AND @original_hits IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_no" Type="Int32" />
                    <asp:Parameter Name="original_irum" Type="String" />
                    <asp:Parameter Name="original_email" Type="String" />
                    <asp:Parameter Name="original_title" Type="String" />
                    <asp:Parameter Name="original_subcontent" Type="String" />
                    <asp:Parameter Name="original_pwd" Type="String" />
                    <asp:Parameter Name="original_regdate" Type="DateTime" />
                    <asp:Parameter Name="original_hits" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="irum" Type="String" />
                    <asp:Parameter Name="email" Type="String" />
                    <asp:Parameter Name="title" Type="String" />
                    <asp:Parameter Name="subcontent" Type="String" />
                    <asp:Parameter Name="pwd" Type="String" />
                    <asp:Parameter Name="regdate" Type="DateTime" />
                    <asp:Parameter Name="hits" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="irum" Type="String" />
                    <asp:Parameter Name="email" Type="String" />
                    <asp:Parameter Name="title" Type="String" />
                    <asp:Parameter Name="subcontent" Type="String" />
                    <asp:Parameter Name="pwd" Type="String" />
                    <asp:Parameter Name="regdate" Type="DateTime" />
                    <asp:Parameter Name="hits" Type="Int32" />
                    <asp:Parameter Name="original_no" Type="Int32" />
                    <asp:Parameter Name="original_irum" Type="String" />
                    <asp:Parameter Name="original_email" Type="String" />
                    <asp:Parameter Name="original_title" Type="String" />
                    <asp:Parameter Name="original_subcontent" Type="String" />
                    <asp:Parameter Name="original_pwd" Type="String" />
                    <asp:Parameter Name="original_regdate" Type="DateTime" />
                    <asp:Parameter Name="original_hits" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>

            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4"
                DataKeyNames="no" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" AllowPaging="True">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="no" HeaderText="no" InsertVisible="False" ReadOnly="True" SortExpression="no" />
                    <asp:BoundField DataField="irum" HeaderText="irum" SortExpression="irum" />
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                    <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                    <asp:BoundField DataField="subcontent" HeaderText="subcontent" SortExpression="subcontent" />
                    <asp:BoundField DataField="pwd" HeaderText="pwd" SortExpression="pwd" />
                    <asp:BoundField DataField="regdate" HeaderText="regdate" SortExpression="regdate" />
                    <asp:BoundField DataField="hits" HeaderText="hits" SortExpression="hits" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
