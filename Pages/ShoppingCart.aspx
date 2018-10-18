<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="TheRightPlace.Pages.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <title>Shopping Cart</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:Panel ID="pnlShoppingCart" runat="server">

    </asp:Panel>
    <table>
        <tr>
            <td><b>Price: </b></td>
            <td><asp:Literal ID="litsubTotal" runat="server" Text=""></asp:Literal></td>
        </tr>
        <tr>
            <td><b>Discount: </b></td>
            <td><asp:Literal ID="litDiscount" runat="server" Text=""></asp:Literal></td>
        </tr>
        <tr>
            <td><b>Grand Total: </b></td>
            <td><asp:Literal ID="litGrandTotal" runat="server" Text=""></asp:Literal></td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="lnkContinue" runat="server" PostBackUrl="~/Pages/Reservations.aspx" Text="Continue Shopping" />
                OR
                <asp:Button ID="btnCheckOut" runat="server" postbackurl="~/Pages/Success.aspx" CssClass="button" Width="250px"  Text="Checkout" />
            </td>
        </tr>
    </table>
</asp:Content>
