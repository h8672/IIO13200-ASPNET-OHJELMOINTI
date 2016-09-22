<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Harjoitukset_Harj2_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data transfer demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Source Page</h1>
        Message to send: <asp:TextBox runat="server" ID="txtMessage" /><br />
        <!--Vaatii tekstin sivulle, puuttuu yksi juttu ja lukee kommentti rivin läpi... ----------- > tää muutettu < -------->
        <!--<asp:RequiredFieldValidator ErrorMessage="Vaatii tektiä" ControlToValidate="txtMessage" raaaunat="server" />-->
        <asp:DropDownList runat="server" ID="ddlMessages" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged" AutoPostBack="True" /><br />
        <asp:Button ID="btnQuery" Text="Case1: Query String" runat="server" OnClick="btnQuery_Click" /><br />
        <asp:Button Text="Case2: Session" ID="btnSession" runat="server" OnClick="btnSession_Click" /><br />
        <asp:Button Text="Case3: Cookie" ID="btnCookie" runat="server" OnClick="btnCookie_Click" /><br />
        <asp:Button Text="Case3: SecretMessage" ID="btnPublicProperty" runat="server" OnClick="btnPublicProperty_Click" /><br />
    </div>
    </form>
</body>
</html>
