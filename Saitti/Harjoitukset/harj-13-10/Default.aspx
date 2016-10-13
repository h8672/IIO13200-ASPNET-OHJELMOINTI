<%@ Page Title="" Language="C#" MasterPageFile="~/Harjoitukset/Tuntiharjoituksia/To29-9/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Harjoitukset_harj_13_10_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:XmlDataSource ID="myDataSource" DataFile="~/App_Data/Työntekijät2013.xml" runat="server" />
    <div id="myDiv" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

