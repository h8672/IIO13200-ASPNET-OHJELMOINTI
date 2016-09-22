<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ikkunadim.aspx.cs" Inherits="Tehtävät_Teht1_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Alumiinikarmisen ikkunan laskin</h1>
        <Table>
            <tr>
                <td>Leveys(L):</td>
                <td><input runat="server" ID="inLeveys"/></td>
                <td>mm</td>
            </tr>
            <tr>
                <td>Korkeus(H):</td>
                <td><input runat="server" ID="inKorkeus"/></td>
                <td>mm</td>
            </tr>
            <tr>
                <td>Karmipuun Leveys(W):</td>
                <td><input runat="server" ID="inKarmi" value="45"/></td>
                <td>mm</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="btnLaske" runat="server" Text="Laske tarjoushinta" OnClick="btnLaske_Click" /></td>
            </tr>
            <tr>
                <td><p runat="server" ID="tbPinta"/></td>
            </tr>
            <tr>
                <td><p runat="server" ID="tbPiiri"/></td>
            </tr>
            <tr>
                <td><p runat="server" ID="tbTarjous"/></td>
            </tr>
        </Table>
        

    </form>
</body>
</html>
