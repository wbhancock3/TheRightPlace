<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageRoomTypes.aspx.cs" Inherits="TheRightPlace.Pages.Management.ManageRoomTypes" %>
<asp:Content ID="ManageRoomTypesHead" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <title>Manage Room Types</title>
</asp:Content>
<asp:Content ID="ManageRoomTypesContent" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <p>
    Name:</p>
<p>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
</p>
<p>
    <asp:Label ID="lblResult" runat="server"></asp:Label>
</p>
</asp:Content>
