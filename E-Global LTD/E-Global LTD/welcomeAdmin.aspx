<%@ Page Title="" Language="C#" MasterPageFile="~/E-Global.Master" AutoEventWireup="true" CodeBehind="welcomeAdmin.aspx.cs" Inherits="E_Global_LTD.welcomeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contain">
        <h1>Welcome</h1>
        <div style="width: 100%; margin-bottom: 1rem">
            <asp:Label ID="labelWelcome" Text="" runat="server" />
        </div> <br />
        <asp:Button ID="Logout" CssClass="button" runat="server" Text="Logout" OnClick="Logout_Click" />
    </div>

    <div class="contain">
        <h1>Add a Product</h1>

        <h2>Product Name</h2>
        <asp:TextBox ID="productName" CssClass="input" runat="server" type="type" placeholder="Enter Product Name"></asp:TextBox>

        <h2>Stock</h2>
        <asp:TextBox ID="productStock" CssClass="input" runat="server" type="type" placeholder="Enter Stock"></asp:TextBox>

        <h2>Price</h2>
        <asp:TextBox ID="productPrice" CssClass="input" runat="server" type="number" placeholder="Enter Price per Unit"></asp:TextBox>
        
        <h2>Description</h2>
        <asp:TextBox style="height: 200px;" TextMode="MultiLine" ID="productDescription" CssClass="input" runat="server" type="text" placeholder="Enter Description"></asp:TextBox>
        
        <h2>Unit</h2>
        <asp:TextBox ID="productUnit" CssClass="input" runat="server" type="text" placeholder="Enter Unit"></asp:TextBox>

        <asp:Button ID="add" Text="Add Product" CssClass="button" runat="server" OnClick="add_Click"/>
        <asp:Label ID="labelResult" CssClass="label" runat="server" Text=""></asp:Label>
    </div>

    <div class="item">
        <asp:GridView ID="productsList" style="width: 100%;" AutoSizeColumnsMode="Fill" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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
    </div>
</asp:Content>
