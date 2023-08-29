<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid.aspx.cs" Inherits="WebApplication_Daniel.Grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="gridFornecedores" runat="server">
        </asp:GridView>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="51px" Width="327px">
        </asp:DropDownList>
    </form>
</body>
</html>
