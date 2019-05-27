<%@ Page Title="" Language="C#" MasterPageFile="~/E-Global.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="E_Global_LTD.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contain">
        <h1>Signup</h1>

        <h2>First Name</h2>
        <asp:TextBox ID="signupFirstName" CssClass="input" runat="server" type="type" placeholder="Enter First Name"></asp:TextBox>

        <h2>Last Name</h2>
        <asp:TextBox ID="signupLastName" CssClass="input" runat="server" type="type" placeholder="Enter Last Name"></asp:TextBox>

        <h2>Username</h2>
        <asp:TextBox ID="signupUsername" CssClass="input" runat="server" type="text" placeholder="Enter Username"></asp:TextBox>
        
        <h2>Password</h2>
        <asp:TextBox ID="signupPassword" CssClass="input" runat="server" type="password" placeholder="Enter Password"></asp:TextBox>
        
        <h2>Email</h2>
        <asp:TextBox ID="signupEmail" CssClass="input" runat="server" type="email" placeholder="Enter Email"></asp:TextBox>

        
        <asp:Button ID="signupButton" Text="Signup" CssClass="button" runat="server" OnClick="signupButton_Click"/>
        <a href="login.aspx" class="button">Login</a>
        <asp:Label ID="labelResult" CssClass="label" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
