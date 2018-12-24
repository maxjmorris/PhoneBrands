<%@ Page Title="" Language="C#" MasterPageFile="~/PhoneBrands.master" AutoEventWireup="true" CodeFile="Phones.aspx.cs" Inherits="Phones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="height: 485px">
        <br />
        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; position: absolute; top: 123px; left: 61px" Text="PhoneNo"></asp:Label>
        <asp:Label ID="lblPhoneName" runat="server" style="z-index: 1; position: absolute; top: 168px; left: 63px" Text="Phone Name"></asp:Label>
        <asp:Label ID="lblCompany" runat="server" style="z-index: 1; position: absolute; top: 213px; left: 62px" Text="Company"></asp:Label>
        <asp:Label ID="lblOperatingSystem" runat="server" style="z-index: 1; position: absolute; top: 259px; left: 60px; margin-top: 0px" Text="Operating System"></asp:Label>
        <asp:TextBox ID="txtbxPhoneNo" runat="server" style="z-index: 1; position: absolute; top: 119px; left: 218px" Height="25px" Width="161px"></asp:TextBox>
        <asp:TextBox ID="txtbxPhoneName" runat="server" style="z-index: 1; position: absolute; top: 170px; left: 218px" Height="25px" Width="161px"></asp:TextBox>
        <asp:TextBox ID="txtbxOperatingSystem" runat="server" style="z-index: 1; position: absolute; top: 261px; left: 218px; margin-top: 0px; width: 161px; height: 24px;" Height="25px" Width="161px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; position: absolute; top: 371px; left: 141px"></asp:Label>
        <asp:CheckBox ID="chkbxActive" runat="server" style="z-index: 1; position: absolute; top: 308px; left: 63px; height: 21px" Text="Active" />
        </p>
</asp:Content>
