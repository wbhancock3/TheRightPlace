<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Reservations.aspx.cs" Inherits="TheRightPlace.Pages.Reservations" %>
<asp:Content ID="requestHead" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <title>Reservations</title>
</asp:Content>
<asp:Content ID="ReservationsContent" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:Panel ID="pnlRooms" runat="server"></asp:Panel>
    <div style ="clear: both"></div>
</asp:Content>
