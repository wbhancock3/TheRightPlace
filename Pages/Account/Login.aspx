<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TheRightPlace.Pages.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
<br />
<br />
Username:<br />
<asp:TextBox ID="txtUsername" runat="server" CssClass="inputs"></asp:TextBox>
<br />
<br />
Password:<br />
<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="inputs"></asp:TextBox>
<br />
<br />
<asp:Button ID="btnLogin" runat="server" CssClass="button" OnClick="btnLogin_Click" Text="Log In" />
</asp:Content>
