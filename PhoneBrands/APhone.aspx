<%@ Page Title="" Language="C#" MasterPageFile="~/PhoneBrands.master" AutoEventWireup="true" CodeFile="APhone.aspx.cs" Inherits="Phones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="height: 485px">
        <br />
        <asp:Label ID="lblPhoneName" runat="server" style="z-index: 1; position: absolute; top: 144px; left: 67px" Text="Phone Name"></asp:Label>
        <asp:Label ID="lblCompany" runat="server" style="z-index: 1; position: absolute; top: 335px; left: 435px; height: 21px; width: 75px;" Text="Company"></asp:Label>
        <asp:Label ID="lblOperatingSystem" runat="server" style="z-index: 1; position: absolute; top: 330px; left: 55px; margin-top: 0px" Text="Operating System"></asp:Label>
        <asp:TextBox ID="txtPhoneName" runat="server" style="z-index: 1; position: absolute; top: 142px; left: 219px; height: 19px;" Width="161px"></asp:TextBox>
        <asp:TextBox ID="txtOperatingSystem" runat="server" style="z-index: 1; position: absolute; top: 320px; left: 215px; margin-top: 0px; width: 161px; height: 24px;" Height="25px" Width="161px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; position: absolute; top: 380px; left: 65px"></asp:Label>
        <asp:CheckBox ID="chkDiscontinued" runat="server" style="z-index: 1; position: absolute; top: 365px; left: 650px; height: 21px" Text="Discontinued" />
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; position: absolute; top: 265px; left: 440px; height: 22px" Text="Release Date"></asp:Label>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; position: absolute; top: 260px; left: 570px; margin-top: 0px; width: 165px; height: 26px; right: -104px;"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" Height="29px" style="z-index: 1; position: absolute; top: 430px; left: 68px" Text="OK" Width="77px" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Height="29px" style="z-index: 1; position: absolute; top: 429px; left: 157px" Text="Cancel" Width="77px" OnClick="btnCancel_Click" />
        <asp:DropDownList ID="ddlCompany" runat="server" style="z-index: 1; position: absolute; top: 330px; left: 585px; width: 167px; height: 19px">
        </asp:DropDownList>
        <asp:Label ID="lblBrand" runat="server" style="z-index: 1; position: absolute; top: 198px; left: 71px; width: 93px" Text="Brand"></asp:Label>
        <asp:TextBox ID="txtBrand" runat="server" style="z-index: 1; position: absolute; top: 195px; left: 217px; width: 165px;"></asp:TextBox>
        <asp:Label ID="lblScreenSize" runat="server" style="z-index: 1; position: absolute; top: 259px; left: 64px" Text="Screen Size"></asp:Label>
        <asp:TextBox ID="txtScreenSize" runat="server" style="z-index: 1; position: absolute; top: 262px; left: 226px; width: 154px;"></asp:TextBox>
        <asp:TextBox ID="txtBackCamera" runat="server" style="z-index: 1; position: absolute; top: 145px; left: 570px"></asp:TextBox>
        <asp:Label ID="lblBackCamera" runat="server" style="z-index: 1; position: absolute; top: 145px; left: 435px" Text="Back Camera"></asp:Label>
        <asp:Label ID="lblBatterySize" runat="server" style="z-index: 1; position: absolute; top: 205px; left: 440px" Text="Battery Size"></asp:Label>
        <asp:TextBox ID="txtBatterySize" runat="server" style="z-index: 1; position: absolute; top: 205px; left: 570px"></asp:TextBox>
    </p>
</asp:Content>

