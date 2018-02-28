<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="User" AutoPostBack="True"/>
            <br />
            <br />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Admin" AutoPostBack="True"/>
    </form>
</body>
</html>
