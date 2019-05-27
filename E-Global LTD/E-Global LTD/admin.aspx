<%@ Page Title="" Language="C#" MasterPageFile="~/E-Global.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="E_Global_LTD.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contain">
        <h1>Login as Admin</h1>

        <h2>Username</h2>
        <asp:TextBox ID="loginAdminUsername" CssClass="input" runat="server" type="text" placeholder="Enter Username"></asp:TextBox>

        <h2>Password</h2>
        <asp:TextBox ID="loginAdminPassword" CssClass="input" runat="server" type="password" placeholder="Enter Password"></asp:TextBox>
        <asp:Button ID="loginAdminButton" CssClass="button" runat="server" Text="Login" OnClick="loginAdminButton_Click" />
        <a href="login.aspx" class="button">Login as User</a>
        <asp:Label ID="labelResult" CssClass="label" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
