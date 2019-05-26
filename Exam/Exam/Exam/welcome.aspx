<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="Exam.welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section">
        <ul class="actions">
            <li>
                <asp:label id="labelResult" text="Welcome" runat="server" />
            </li>
        </ul>
    </div>
    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Button ID="buttonLogout" Text="Log out" runat="server" OnClick="buttonLogout_Click" />
    <asp:Button ID="buttonDeleteAccount" Text="Delete Account" runat="server" OnClick="buttonDeleteAccount_Click" />
</asp:Content>
