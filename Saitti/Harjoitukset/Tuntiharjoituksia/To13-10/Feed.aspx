<%@ Page Title="" Language="C#" MasterPageFile="~/Harjoitukset/Tuntiharjoituksia/To29-9/MasterPage.master" AutoEventWireup="true" CodeFile="Feed.aspx.cs" Inherits="Harjoitukset_Tuntiharjoituksia_To13_10_Feed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="btnGetFeeds" Text="Feedit Iltasanomat" runat="server" OnClick="btnGetFeeds_Click"/>
    <asp:Button ID="btnGetFeedsYle" Text="Feedit Yle" runat="server" OnClick="btnGetFeedsYle_Click"/>
    <div id="myDiv" runat="server" />
    <asp:XmlDataSource ID="myDataSource" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

