<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="WebApplication2.AdminView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Height="178px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="263px"></asp:ListBox>
            <asp:ListBox ID="ListBox2" runat="server" Height="177px" Width="211px"></asp:ListBox>
            <asp:ListBox ID="ListBox3" runat="server" Height="177px" Width="216px"></asp:ListBox>
            <asp:ListBox ID="ListBox4" runat="server" Height="178px" Width="218px"></asp:ListBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" />
    </form>
</body>
</html>
