<%@ Page Title="" Language="C#" MasterPageFile="~/Harjoitukset/Tuntiharjoituksia/To29-9/MasterPage.master" AutoEventWireup="true" CodeFile="MoviesSQL.aspx.cs" Inherits="Harjoitukset_Tuntiharjoituksia_To29_9_MoviesSQL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h1>Esa's movies from SQL server!</h1>
    <!-- DataSource määrittely -->
    <asp:SqlDataSource runat="server" ID="srcMovies" ConnectionString="<%$ ConnectionStrings:MoviesIP %>" SelectCommand="SELECT [title], [director], [year] FROM [Movies]" />
    <!-- GV-kontrolli esittää datan -->
    <asp:GridView runat="server" DataSourceID="srcMovies" HeaderStyle-ForeColor="White" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="director" HeaderText="director" SortExpression="director" />
            <asp:BoundField DataField="year" HeaderText="year" SortExpression="year" />
        </Columns>
<HeaderStyle ForeColor="White"></HeaderStyle>
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

