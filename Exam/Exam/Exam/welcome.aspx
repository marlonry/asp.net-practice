<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="Exam.welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section">
        <div class="inner small">
                <asp:Button ID="button1" CssClass="alt" Text="Log out" runat="server" OnClick="buttonLogout_Click" /> &nbsp;
                <asp:Button ID="buttonDeleteAccount" CssClass="alt" Text="Delete Account" runat="server" OnClick="buttonDeleteAccount_Click" /> &nbsp;
                <asp:Button ID="buttonUpdateDetails" CssClass="alt" runat="server" Text="Update Details" OnClick="buttonUpdateDetails_Click" /> <br />
            <br />
            
            <asp:label id="labelResult" text="" runat="server" />
        </div>
    </div>
    
</asp:Content>
