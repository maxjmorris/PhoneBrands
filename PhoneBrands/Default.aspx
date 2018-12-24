<%@ Page Title="" Language="C#" MasterPageFile="~/PhoneBrands.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>



<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:ListBox ID="lstPhones" runat="server" style="z-index: 1; position: absolute; top: 52px; left: 16px; width: 526px; height: 229px" OnSelectedIndexChanged="lstPhones_SelectedIndexChanged"></asp:ListBox>
    <p>
        &nbsp;</p>
    <asp:Button ID="btnEdit" runat="server" style="z-index: 1; position: absolute; top: 449px; left: 119px; height: 29px;" Text="Edit" Width="68px" OnClick="btnEdit_Click" />
    <p>
        &nbsp;</p>
    <asp:Button ID="btnApply" runat="server" style="z-index: 1; position: absolute; top: 397px; left: 35px" Text="Apply" Height="29px" Width="114px" OnClick="btnApply_Click" />
    <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; position: absolute; top: 398px; left: 164px" Text="Display All" Height="29px" Width="114px" OnClick="btnDisplayAll_Click" />
    <asp:Button ID="btnAdd" runat="server" Height="29px" style="z-index: 1; position: absolute; top: 449px; left: 42px" Text="Add" Width="68px" OnClick="btnAdd_Click" />
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; position: absolute; top: 283px; left: 21px"></asp:Label>
    </p>
    <asp:Label ID="lblPhoneBrands" runat="server" style="z-index: 1; position: absolute; top: 325px; left: 23px; width: 260px" Text="Please Enter  A Phone Brand"></asp:Label>
    <p>
        <asp:TextBox ID="txtPhoneBrands" runat="server" style="z-index: 1; position: absolute; top: 357px; left: 20px; width: 259px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <asp:Button ID="btnDelete" runat="server" Height="29px" OnClick="btnDelete_Click" style="z-index: 1; position: absolute; top: 449px; left: 199px" Text="Delete" Width="68px" />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>




