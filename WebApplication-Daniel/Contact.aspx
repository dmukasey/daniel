<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication_Daniel.Contact" %>

<%@ Register src="menu.ascx" tagname="menu" tagprefix="uc1" %>

<%@ Register assembly="Daniel.Web.UI" namespace="Daniel.Web.UI" tagprefix="cc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>
            <uc1:menu ID="menu1" runat="server" />
    </h2>
        <h3>Your contact page.<cc1:TextBoxCNPJ ID="TextBoxCNPJ1" runat="server"></cc1:TextBoxCNPJ>
    </h3>
        <address>
            One Microsoft Way<br />
            Redmond, WA 98052-6399<br />
            <abbr title="Phone">P:</abbr>
            425.555.0100
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
        </address>
    </main>
</asp:Content>
