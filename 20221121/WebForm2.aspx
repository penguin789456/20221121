<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_20221121.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
            <asp:TextBox ID="namebox" runat="server"></asp:TextBox><br>
             <asp:Label ID="Label2" runat="server" Text="gender"></asp:Label>
            <asp:TextBox ID="genserbox" runat="server"></asp:TextBox><br>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
