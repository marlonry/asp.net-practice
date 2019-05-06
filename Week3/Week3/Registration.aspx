<%@ Page Title="" Language="C#" MasterPageFile="~/Store.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Week3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%--Registration Content--%>
<asp:Content ID="Content2" ContentPlaceHolderID="Registration" runat="server">
    <div class="user">
        <header class="user__header">
            <img src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/3219/logo.svg" alt="" />
            <h1 class="user__title">A lightweight and simple sign-up form</h1>
        </header>
    
        <form class="form" runat="server">
            <div class="form__group">
                <%--<input type="text" placeholder="Username" class="form__input" />--%>
                <asp:TextBox ID="txtUsername" CssClass="form__input" placeholder="Username" runat="server"></asp:TextBox>
            </div>
        
            <div class="form__group">
                <%--<input type="email" placeholder="Email" class="form__input" />--%>
                <asp:TextBox ID="txtEmail" CssClass="form__input"  placeholder="Email" runat="server"></asp:TextBox>
            </div>
        
            <div class="form__group">
                <%--<input type="password" placeholder="Password" class="form__input" />--%>
                <asp:TextBox ID="txtPassword" CssClass="form__input"  placeholder="Password" runat="server"></asp:TextBox>
            </div>
        
            <asp:Button ID="btnRegister" CssClass="btn" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
            <%--<button class="btn" type="button">Register</button>--%>


        </form>
    </div>
</asp:Content>
