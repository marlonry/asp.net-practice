<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Exam.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <footer id="footer">
        <div class="inner small">
            <h3>Log In</h3>

            <div class="field">
                <label for="loginUsername">Username</label>
                <asp:TextBox ID="loginUsername" type="text" runat="server" placeholder="Username"></asp:TextBox>
            </div>

            <div class="field">
                <label for="loginPassword">Password</label>
                <asp:TextBox ID="loginPassword" runat="server" placeholder="Password" type="password"></asp:TextBox>
            </div>

            <%--This is for the register copy it to the register page when i start creating that page--%>

            <%--<div class="field">
                <label for="loginEmail">Email</label>
                <asp:TextBox ID="loginEmail" type="email" runat="server" placeholder="Email"></asp:TextBox>
            </div>--%>

            <ul class="actions">
                <li>
                    <asp:Button ID="loginButton" CssClass="button alt" runat="server" Text="Login" OnClick="loginButton_Click"/>
                </li>

                <li>
                    <asp:Label CssClass="" ID="labelResult" Text="" runat="server" />
                </li>
            </ul>
        </div>
    </footer>
    
</asp:Content>
