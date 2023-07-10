<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_teste.aspx.cs" Inherits="WebApplication_Daniel.WebForm_teste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body id="lbl_mensagem">
    <form id="form1" runat="server">
        <div>
        </div>
        <p class="auto-style1">
            Bem vindo. Faça o login
        </p>
        <p class="auto-style1">
            &nbsp;
        </p>
        <asp:RadioButtonList ID="rbl_tipo" runat="server" Style="margin-left: 682px" Width="164px">
            <asp:ListItem Value="For">Fornecedor</asp:ListItem>
            <asp:ListItem Value="Cli">Cliente</asp:ListItem>
        </asp:RadioButtonList>
        <p class="auto-style1">
            &nbsp;
        </p>
        <p class="auto-style1">
            Usuário:
            <asp:TextBox ID="txt_user" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_user" ErrorMessage="Preencha o usuário!" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p class="auto-style1">
            Senha:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_pass" ErrorMessage="Preencha a senha!" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>

        <p style="text-align: center">
            <asp:Button ID="btn_enviar" runat="server" OnClick="btn_enviar_Click" Style="text-align: center" Text="Enviar" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" Style="text-align: center" />
            <p>
                <asp:Label ID="lbl_mensagem" runat="server" ForeColor="#CC0000" Style="text-align: center"></asp:Label>
            </p>
        </p>
    </form>
</body>
</html>
