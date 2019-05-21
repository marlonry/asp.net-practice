<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="schedule.aspx.cs" Inherits="Week2.WebForm4" %>

<%--Head--%>
<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <title>Contacts | Art School</title>
</asp:Content>

<%--Content--%>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
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
              
              <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="Black" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" GridLines="Vertical">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table>
                            <thead>
                            <tr>
                            <td>Day &nbsp;</td>
                                              
                            <td>Time &nbsp;</td>
                       
                            <td>Class &nbsp;</td>
                       
                            <td>Schedule &nbsp;</td>
                        </tr>
                                </thead>
                        
                    </HeaderTemplate>
                    <ItemStyle BackColor="#F7F7DE" />
                  <ItemTemplate>
                      <tbody>
                      <tr>
                            <td>
                                <%#Eval("day") %> &nbsp;
                            </td>
                       
                            <td>
                                 <%#Eval("time") %> &nbsp;
                            </td>
                        
                            <td>
                                 <%#Eval("topic") %> &nbsp;
                            </td>
                        
                            <td>
                                 <%#Eval("tutor") %> &nbsp;
                            </td>
                          <td>
                              <asp:LinkButton ID="LinkButton1" runat="server" Onclick="LinkButton1_Click" CommandArgument='<%#Eval("id") %>' >Select</asp:LinkButton>
                          </td>
                        </tr>
                    </tbody>
                          
                      </ItemTemplate>

                   <FooterTemplate>
                       </table>
                   </FooterTemplate>
                    <SelectedItemStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />

                   
              </asp:DataList>
          </div>
        </div>
      </div>
    </form>
</asp:Content>
