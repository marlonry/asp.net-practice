<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="Exam.update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section">
        <div class="inner small">

            <h3>Update Details</h3>

            <div class="field">
                <label for="updateUsername">Username</label>
                <asp:TextBox ID="updateUsername" type="text" runat="server"></asp:TextBox>
            </div>

            <div class="field">
                <label for="updatePassword">Password</label>
                <asp:TextBox ID="updatePassword" type="password" runat="server"></asp:TextBox>
            </div>

            <div class="field">
                <label for="updateEmail">Email</label>
                <asp:TextBox ID="updateEmail" type="email" runat="server"></asp:TextBox>
            </div>

            <asp:Button CssClass="alt" ID="save" runat="server" Text="Save Details" OnClick="save_Click" />

            <asp:label id="labelResult" text="" runat="server" />
        </div>
    </div>
</asp:Content>
