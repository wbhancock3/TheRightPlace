<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Rooms.aspx.cs" Inherits="TheRightPlace.Pages.Rooms" %>
<asp:Content ID="RoomsHead" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <title>Rooms</title>
</asp:Content>
<asp:Content ID="RoomsContent" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgRoom" runat="server" CssClass="detailsImage" /></td>
            <td><h2>
                <asp:Label ID="lblTitle" runat="server" ></asp:Label>
                
                </h2></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label></td>
            <td>
                <h2><asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label></h2>
                <p>Quantity: 
                <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList></p>
                <asp:Button ID="btnAdd" runat="server" Text="Add Product" CssClass="button" OnClick="btnAdd_Click" />
                <br />
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Room Number: <asp:Label ID="lblRoomNbr" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>
            <asp:Label ID="lblAvailability" runat="server" Text="Available" CssClass="roomPrice"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
