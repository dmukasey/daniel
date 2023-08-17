<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication_Daniel._Default" %>

<%@ Register src="menu.ascx" tagname="menu" tagprefix="uc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p>
                <uc1:menu ID="menu1" runat="server" />
            </p>
            <p>&nbsp;</p>
            <p class="lead">Bem vindo ao sistema <%=ConfigurationManager.AppSettings["NomeAplicacao"] %></p>

            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div class="row">
            
            a alteração tem que subir
        </div>
    </main>

</asp:Content>
