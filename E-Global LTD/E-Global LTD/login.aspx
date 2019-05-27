<%@ Page Title="" Language="C#" MasterPageFile="~/E-Global.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="E_Global_LTD.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contain">
        <h1>Login</h1>

        <h2>Username</h2>
        <asp:TextBox ID="loginUsername" CssClass="input" runat="server" type="text" placeholder="Enter Username"></asp:TextBox>

        <h2>Password</h2>
        <asp:TextBox ID="loginPassword" CssClass="input" runat="server" type="password" placeholder="Enter Password"></asp:TextBox>
        <asp:Button ID="loginButton" CssClass="button" runat="server" Text="Login" OnClick="loginButton_Click"/>
        <a href="register.aspx" class="button">Signup</a>
        <a href="admin.aspx" class="button">Login as Admin</a>
        <asp:Label ID="labelResult" CssClass="label" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

