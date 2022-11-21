<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="_20221121.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" PostBackUrl="~/WebForm5.aspx" />
        </div>
    </form>
</body>
</html>
