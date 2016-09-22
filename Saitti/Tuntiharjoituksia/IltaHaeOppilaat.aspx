<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IltaHaeOppilaat.aspx.cs" Inherits="Tuntiharjoituksia_IltaHaeOppilaat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Oppilaat</h1>
        <div id="buttoset">
            <asp:Button ID="btnGet3" runat="server" Text="Hae 3 oppilasta" OnClick="btnGet3_Click" />
            <asp:Button ID="btnGetAll" runat="server" Text="Hae kaikki oppilaat" OnClick="btnGetAll_Click" />
            <asp:Button ID="btnGet4" Text="Hae 4 oppilasta" runat="server" OnClick="btnGet4_Click" />
        </div>
        <div id="data">
            <div runat="server" id="outMessage" />
            <asp:GridView ID="gvStudents" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
