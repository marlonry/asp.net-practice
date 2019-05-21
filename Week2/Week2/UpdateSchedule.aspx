<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateSchedule.aspx.cs" Inherits="Week2.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="grid_4 bot-1">
        <h2 class="top-6 p6">About Schedule</h2>
        <p class="clr-7 p7"><strong>At vero eos et accusam et justo duo dolores et ea rebum.</strong></p>
        <p class="p7">Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor. Loremsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy.</p>
        <p>Eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum <br>
          dolor sit amet <a href="#" class="link">More...</a></p>
      </div>
    <form runat="server">
      <div class="grid_8">
        <div class="block-1 top-5">
          <div class="block-1-shadow">
              <div>
                 <label for="txtday">Day</label>
                 <asp:TextBox ID="txtday" runat="server" placeholder="enter day"></asp:TextBox>
              </div>

              <div>
                 <label for="txttime">Time</label>
                 <asp:TextBox ID="txttime" runat="server" placeholder="enter time"></asp:TextBox>
              </div>

              <div>
                 <label for="txttopic">Topic</label>
                 <asp:TextBox ID="txttopic" runat="server" placeholder="enter topic"></asp:TextBox>
              </div>

              <div>
                 <label for="txttutor">Tutor</label>
                 <asp:TextBox ID="txttutor" runat="server" placeholder="enter tutor"></asp:TextBox>
              </div>

              <div>
                  <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
                  <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click"/>
              </div>
          </div>
        </div>
      </div>
    </form>
</asp:Content>
