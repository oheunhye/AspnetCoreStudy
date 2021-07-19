<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userMsg.ascx.cs" Inherits="_04_Sample.userMsg" %>

<!-- userMain의 사용자 정의 컨트롤로 불려짐 -->
<asp:Panel ID="pnlMessage" runat="server" Visible="false">
    <div id="msgIcon" runat="server" class="message-icon"></div>
    <div class="message-text">
        <asp:Literal ID="litMsg" runat="server"></asp:Literal>
    </div>
    <asp:Button id="btnOk" class="message-btn" runat="server" Text="확인" OnClick="btnOk_Click"/>
</asp:Panel>

