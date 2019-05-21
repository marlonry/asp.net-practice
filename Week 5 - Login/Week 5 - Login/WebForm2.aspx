<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Week_5___Login.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Welcome</h1>
        <asp:TextBox ID="txtUser" CssClass="input" runat="server" disabled="true"></asp:TextBox>
        <asp:Button ID="Logout" CssClass="button" runat="server" Text="Logout" OnClick="Login_Click" />
        <asp:Button ID="Delete" CssClass="button" runat="server" Text="Delete Account" OnClick="Delete_Click"/>
        <asp:Button ID="seeMore" Text="See More" CssClass="button" runat="server" OnClick="seeMore_Click" />

        <asp:Panel ID="panel" runat="server" CssClass="panel" Visible="false">
            <h2>New Username</h2>
            <asp:TextBox ID="updateUsername" CssClass="input" runat="server" type="text" placeholder="Enter New Username"></asp:TextBox>
        
            <h2>New Password</h2>
            <asp:TextBox ID="updatePassword" CssClass="input" runat="server" type="text" placeholder="Enter New Password"></asp:TextBox>
        
            <h2>New Email</h2>
            <asp:TextBox ID="updateEmail" CssClass="input" runat="server" type="email" placeholder="Enter New Email"></asp:TextBox>
        
            <asp:Button ID="updateData" Text="Update Details" CssClass="button" runat="server" OnClick="updateData_Click" />
        
            <asp:Label ID="labelResult" CssClass="label" runat="server" Text=""></asp:Label>
        </asp:Panel>
    </div>
</asp:Content>
