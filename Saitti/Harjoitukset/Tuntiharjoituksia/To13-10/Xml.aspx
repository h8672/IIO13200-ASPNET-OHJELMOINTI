﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Harjoitukset/Tuntiharjoituksia/To29-9/MasterPage.master" AutoEventWireup="true" CodeFile="Xml.aspx.cs" Inherits="Harjoitukset_Tuntiharjoituksia_To13_10_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Xml ID="Xml1"
        DocumentSource="~/App_Data/Työntekijät2013.xml" 
        TransformSource="~/App_Data/Demo.xsl"
        runat="server"></asp:Xml>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

