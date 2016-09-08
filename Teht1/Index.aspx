<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Teht1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Harj1 demot</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Harj1 Demot</h1>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Harj1.aspx" runat="server">Tiedon välitys</asp:HyperLink><br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Harj1.aspx" runat="server">JSON testi</asp:HyperLink><br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="~/Harj1.aspx" runat="server">Datagrid</asp:HyperLink>
    </div>
    </form>
</body>
</html>
