<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Week_5___Login.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Signup</h1>
        <h2>Username</h2>
        <asp:TextBox ID="signupUsername" CssClass="input" runat="server" type="text" placeholder="Enter Username"></asp:TextBox>
        
        <h2>Password</h2>
        <asp:TextBox ID="signupPassword" CssClass="input" runat="server" type="password" placeholder="Enter Password"></asp:TextBox>
        
        <h2>Email</h2>
        <asp:TextBox ID="signupEmail" CssClass="input" runat="server" type="email" placeholder="Enter Email"></asp:TextBox>
        <asp:Button ID="signupButton" Text="Signup" CssClass="button" runat="server" OnClick="signupButton_Click"/>
        <a href="WebForm1.aspx" class="button">Login</a>
        <asp:Label ID="labelResult" CssClass="label" runat="server" Text=""></asp:Label>

    </div>
</asp:Content>
