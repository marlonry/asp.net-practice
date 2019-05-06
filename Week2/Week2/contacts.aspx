<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="contacts.aspx.cs" Inherits="Week2.WebForm2" %>

<%--Head--%>
<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <title>Contacts | Art School</title>
</asp:Content>

<%--Content--%>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="grid_4 bot-1">
        <h2 class="top-6">Contact Us</h2>
        <div class="map">
          <iframe src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Brooklyn,+New+York,+NY,+United+States&amp;aq=0&amp;sll=37.0625,-95.677068&amp;sspn=61.282355,146.513672&amp;ie=UTF8&amp;hq=&amp;hnear=Brooklyn,+Kings,+New+York&amp;ll=40.649974,-73.950005&amp;spn=0.01628,0.025663&amp;z=14&amp;iwloc=A&amp;output=embed"></iframe>
        </div>
        <dl>
          <dt>8901 Marmora Road, <br>
            Glasgow, D04 89GR.</dt>
          <dd><span>Telephone: </span>+1 800 603 6035</dd>
          <dd><span>E-mail: </span><a href="#" class="link">mail@demolink.org</a></dd>
        </dl>
      </div>
      <div class="grid_8">
        <div class="block-1 top-5">
          <div class="block-1-shadow">
            <h2 class="clr-6">Contact Form</h2>
            <form id="form" runat="server">
              <fieldset>
                  <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
                  <div class="section" style="">
                    <asp:Label ID="lblName" runat="server" Text="Name">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </asp:Label>
                  </div>

                  <div class="section">
                      <asp:Label ID="lblPhone" runat="server" Text="Phone">
                          <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                      </asp:Label>
                  </div>

                  <div class="section">
                  <asp:Label ID="lblEmail" runat="server" Text="Email">
                      <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                  </asp:Label>
                    </div>

                  <div class="section">
                    <asp:Label ID="lblMessage" runat="server" Text="Message">
                        <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
                    </asp:Label>
                  </div>

                  <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                  
              </fieldset>
            </form>
          </div>
        </div>
    </div>
</asp:Content>