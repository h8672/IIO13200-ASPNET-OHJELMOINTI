<%@ Page Language="C#" MasterPageFile="~/Harjoitukset/Tuntiharjoituksia/To29-9/MasterPage.master" AutoEventWireup="true" CodeFile="Moviesfrom.aspx.cs" Inherits="Harjoitukset_Tuntiharjoituksia_To29_9_Moviesfrom" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <title>XMLDataSource example</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <!-- XMLDataSource määrittely -->
    <asp:XmlDataSource ID="srcMovies" runat="server" DataFile="~/App_Data/Movies.xml" XPath="//Movie" />
    <!-- GridView-kontrolli esittää datan -->
    <h1>Esa's movies from XML file</h1>
    <asp:GridView runat="server" DataSourceID="srcMovies" HeaderStyle-ForeColor="White" />
    <!-- Datan esittäminen HTML:ssä -->
    <h1>Elokuvat listattuna</h1>
    <ul class="w3-light-grey">
    <asp:Repeater ID="Repeater1" DataSourceID="srcMovies" runat="server">
        <ItemTemplate>
            <li><%# Eval("Name") %>
                <ul>
                    <li><%# Eval("Director") %></li>
                    <li><%# Eval("Country") %></li>
                </ul>
            </li>
        </ItemTemplate>
    </asp:Repeater>
    </ul>
    <table class="w3-light-green">
        <asp:Repeater ID="Repeater2" DataSourceID="srcMovies" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Director") %></td>
                    <td><%# Eval("Country") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">

</asp:Content>
