<%@ Page Title="" Language="C#" MasterPageFile="~/Harjoitukset/Tuntiharjoituksia/To29-9/MasterPage.master" AutoEventWireup="true" CodeFile="BookShop.aspx.cs" Inherits="Harjoitukset_Tuntiharjoituksia_To3_11_BookShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h1>Kirjakauppa</h1>
    <div class="w3-row">
        <!--Vasen lohko asiakkaille-->
        <div class="w3-container w3-third">
            <asp:Button Text="Get customers" CssClass="w3-btn" ID="btnGetCustomers" OnClick="btnGetCustomers_Click" runat="server" />
            <asp:DropDownList ID="ddlSelect" runat="server" OnSelectedIndexChanged="ddlSelect_SelectedIndexChanged" AutoPostBack="true" />
            <asp:GridView ID="gvCustomers" runat="server" />
        </div>
        <!--Oikea lohko -->
        <div class="w3-container w3-twothird">
            <asp:Button Text="Get books" CssClass="w3-btn" ID="btnGetBooks" OnClick="btnGetBooks_Click" runat="server" />
            <asp:GridView ID="gvBooks" runat="server" />
        </div>
    </div>
    <asp:Label Text="Result" ID="ltResult" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
    <asp:Label ID="lblMessages" runat="server" />
</asp:Content>

