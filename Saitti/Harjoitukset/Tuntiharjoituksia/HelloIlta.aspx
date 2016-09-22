<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HelloIlta.aspx.cs" Inherits="HelloIlta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Terve, iltatähdet</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hello</h1>
        <asp:TextBox ID="txtName" runat="server"/>
        <asp:Button ID="btnsayHello" runat="server" Text="Hei" OnClick="btnsayHello_Click" />
        <br />
        <asp:Label ID="lblText" runat="server">...</asp:Label>
    </div>
    </form>
</body>
</html>
