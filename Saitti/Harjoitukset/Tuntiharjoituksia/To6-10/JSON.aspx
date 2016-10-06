<%@ Page Language="C#" MasterPageFile="~/Harjoitukset/Tuntiharjoituksia/To29-9/MasterPage.master" AutoEventWireup="true" CodeFile="JSON.aspx.cs" Inherits="Harjoitukset_Tuntiharjoituksia_To6_10_JSON" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Button ID="btnGet" Text="Hae Json-teksti" runat="server" OnClick="btnGet_Click" />
    <asp:Button ID="btnGetPerson" Text="Hae Json ja muuta olioksi" runat="server" OnClick="btnGetPerson_Click" />
    <asp:Button ID="btnGetPolticis" Text="Hae Json ja muuta jtn..." runat="server" OnClick="btnGetPolticis_Click" />
    <br />
    <asp:Literal ID="ltResult" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">

</asp:Content>