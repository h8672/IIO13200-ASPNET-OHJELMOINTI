<%@ Page Language="C#" MasterPageFile="~/Harjoitukset/Tuntiharjoituksia/To29-9/MasterPage.master" AutoEventWireup="true" CodeFile="TestMySQL.aspx.cs" Inherits="Harjoitukset_Tuntiharjoituksia_To6_10_TestMySQL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <h2>SQLDataSourcen avulla</h2>
    <asp:SqlDataSource ID="srcMySQL" runat="server"
        ConnectionString="<%$ ConnectionStrings:OmaSQL %>"
        DeleteCommand="DELETE FROM City WHERE id=@id"
        ProviderName="MySql.Data.MySqlClient"
        SelectCommand="SELECT * FROM City"
        UpdateCommand="UPDATE City SET name=@name, countrycode=@countrycode, population=@population WHERE id=@id" />
    <asp:GridView ID="gvCities2" DataSourceID="srcMySQL" runat="server" >
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>

    <h2>Kaupungit luokan metodin avulla</h2>
    <asp:Button Text="Hae kaupungit MySQL:llä" ID="btnGetCities" OnClick="btnGetCities_Click" runat="server" />
    <asp:GridView runat="server" ID="gvCities" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <asp:Label ID="lblMessages" runat="server" />
</asp:Content>
