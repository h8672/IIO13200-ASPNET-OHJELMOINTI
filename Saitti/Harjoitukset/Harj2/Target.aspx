<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Target.aspx.cs" Inherits="Harjoitukset_Harj2_Target" %>

<!--Lisätäänm uusi directiivi, osa SecretMessagea-->
<%@ PreviousPageType VirtualPath="~/Harjoitukset/Harj2/Source.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Transfer Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Target Page</h1>
        The message sent to this page is: <div id="mytext" runat="server" />
    </div>
        <asp:HyperLink NavigateUrl="Source.aspx" runat="server" Text="Takaisin" ID="HyperLink1" />
    </form>
</body>
</html>
