<%@ Page Title="" Language="C#" MasterPageFile="~/PhoneBrands.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p style="height: 406px">
        <asp:Label ID="lblDeletePhoneNo" runat="server" style="z-index: 1; position: absolute; top: 154px; left: 34px; margin-top: 0px" Text="Are you sure you want to delete this Phone?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" Height="28px" OnClick="btnYes_Click" style="z-index: 1; position: absolute; top: 184px; left: 55px; margin-top: 0px" Text="Yes" Width="70px" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; position: absolute; top: 184px; left: 144px; height: 28px" Text="No" Width="70px" OnClick="btnNo_Click" />
    </p>
</asp:Content>

