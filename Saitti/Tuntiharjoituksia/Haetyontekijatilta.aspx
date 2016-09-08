<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Haetyontekijatilta.aspx.cs" Inherits="Haetyontekijatilta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Firman X työntekijät</title>
    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnHae" CssClass="w3-btn w3-green" Text="Hae työntekijät" runat="server" OnClick="btnHae_Click"  class="w3-green"/>
            <!--Esitys-->
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
        </div>
        <div class="w3-blue-grey">
            <asp:Label ID="lblMessage" runat="server" Text="..."></asp:Label>
        </div>
    </form>
</body>
</html>
