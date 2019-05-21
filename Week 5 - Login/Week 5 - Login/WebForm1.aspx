<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Week_5___Login.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Login</h1>

        <h2>Username</h2>
        <asp:TextBox ID="txtUser" CssClass="input" runat="server" type="text" placeholder="Enter Username"></asp:TextBox>

        <h2>Password</h2>
        <asp:TextBox ID="txtPass" CssClass="input" runat="server" type="password" placeholder="Enter Password"></asp:TextBox>
        <asp:Button ID="Button1" CssClass="button" runat="server" Text="Login" OnClick="Button1_Click"/>
        <a href="WebForm3.aspx" class="button">Signup</a>
        <asp:Label ID="labelResult" CssClass="label" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
