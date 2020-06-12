<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
        <br />
        <br />
        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
        <br />
        <br />
        <asp:ListBox ID="nameListBox" runat="server"></asp:ListBox>
    </form>
</body>
</html>
