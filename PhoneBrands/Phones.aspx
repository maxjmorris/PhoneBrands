<%@ Page Title="" Language="C#" MasterPageFile="~/PhoneBrands.master" AutoEventWireup="true" CodeFile="Phones.aspx.cs" Inherits="Phones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="height: 485px">
        <br />
        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; position: absolute; top: 123px; left: 61px" Text="PhoneNo"></asp:Label>
        <asp:Label ID="lblPhoneName" runat="server" style="z-index: 1; position: absolute; top: 168px; left: 63px" Text="Phone Name"></asp:Label>
        <asp:Label ID="lblCompany" runat="server" style="z-index: 1; position: absolute; top: 296px; left: 59px; height: 21px; width: 75px;" Text="Company"></asp:Label>
        <asp:Label ID="lblOperatingSystem" runat="server" style="z-index: 1; position: absolute; top: 220px; left: 59px; margin-top: 0px" Text="Operating System"></asp:Label>
        <asp:TextBox ID="txtbxPhoneNo" runat="server" style="z-index: 1; position: absolute; top: 119px; left: 218px" Height="25px" Width="161px"></asp:TextBox>
        <asp:TextBox ID="txtbxPhoneName" runat="server" style="z-index: 1; position: absolute; top: 170px; left: 218px" Height="25px" Width="161px"></asp:TextBox>
        <asp:TextBox ID="txtbxOperatingSystem" runat="server" style="z-index: 1; position: absolute; top: 217px; left: 218px; margin-top: 0px; width: 161px; height: 24px;" Height="25px" Width="161px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; position: absolute; top: 377px; left: 67px"></asp:Label>
        <asp:CheckBox ID="chkbxActive" runat="server" style="z-index: 1; position: absolute; top: 338px; left: 66px; height: 21px" Text="Active" />
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; position: absolute; top: 259px; left: 61px; height: 22px" Text="Release Date"></asp:Label>
        <asp:TextBox ID="txtbxReleaseDate" runat="server" style="z-index: 1; position: absolute; top: 260px; left: 217px; margin-top: 0px; width: 176px; height: 26px;"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" Height="29px" style="z-index: 1; position: absolute; top: 430px; left: 68px" Text="OK" Width="77px" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Height="29px" style="z-index: 1; position: absolute; top: 429px; left: 157px" Text="Cancel" Width="77px" OnClick="btnCancel_Click" />
        <asp:DropDownList ID="ddlCompany" runat="server" style="z-index: 1; position: absolute; top: 300px; left: 218px; width: 167px; height: 19px">
        </asp:DropDownList>
    </p>
</asp:Content>

