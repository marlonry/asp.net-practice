<%@ Page Title="" Language="C#" MasterPageFile="~/E-Global.Master" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="E_Global_LTD.welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contain">
        <h1>Welcome</h1>
        <div style="width: 100%">
            <asp:Label ID="labelWelcome" Text="" runat="server" />
        </div> <br />
        <asp:Button ID="Logout" CssClass="button" runat="server" Text="Logout" OnClick="Logout_Click" />
        <asp:Button ID="Delete" CssClass="button" runat="server" Text="Delete Account" OnClick="Delete_Click"/>
        <asp:Button ID="seeMore" Text="See More" CssClass="button" runat="server" OnClick="seeMore_Click" />

        <asp:Panel ID="panel" runat="server" CssClass="panel" Visible="false">
            <h2>Update First Name</h2>
            <asp:TextBox ID="updateFirstName" CssClass="input" runat="server" type="text" placeholder="Enter New Name"></asp:TextBox>

            <h2>Update Last Name</h2>
            <asp:TextBox ID="updateLastName" CssClass="input" runat="server" type="text" placeholder="Enter New Last Name"></asp:TextBox>

            <h2>New Username</h2>
            <asp:TextBox ID="updateUsername" CssClass="input" runat="server" type="text" placeholder="Enter New Username"></asp:TextBox>
        
            <h2>New Password</h2>
            <asp:TextBox ID="updatePassword" CssClass="input" runat="server" type="text" placeholder="Enter New Password"></asp:TextBox>
        
            <h2>New Email</h2>
            <asp:TextBox ID="updateEmail" CssClass="input" runat="server" type="email" placeholder="Enter New Email"></asp:TextBox>
        
            <asp:Button ID="updateData" Text="Update Details" CssClass="button" runat="server" OnClick="updateData_Click"  />
        
            <asp:Label ID="labelResult" CssClass="label" runat="server" Text=""></asp:Label>
        </asp:Panel>
    </div>

    <div class="contain">
        <h1>Products</h1>
        <asp:TextBox ID="productSearch" CssClass="input" runat="server" type="text" placeholder="Enter New Password"></asp:TextBox>
        <asp:Button ID="searchButton" Text="Search" CssClass="button" runat="server" OnClick="searchButton_Click" />
        
    </div>

     <div class="item">
         <asp:GridView style="width: 100%" ID="productsList" AutoSizeColumnsMode="Fill" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
         </asp:GridView>
         <asp:Label ID="resultSearch" CssClass="label" runat="server" Text=""></asp:Label>
      </div>
</asp:Content>
