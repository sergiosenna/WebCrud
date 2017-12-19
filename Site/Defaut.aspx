﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defaut.aspx.cs" Inherits="Site.defaut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home - Meu Site com  Crud</title>
    <link type="text/css" href="Content/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="estilo.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div>   
           <nav id="menu" style="background-color: #000000;">
            <span id="menu_text">
                 S&S - Serviços e Software
            </span>
           </nav>
        </div >
        <div class="jumbotron">
            <h1>Projeto Crud - Controle de Clientes</h1>

            Selecione a  opção desejada:
            <asp:DropDownList ID="ddlMenu" runat="server">
                <asp:ListItem Value="0" Text="- Escolha uma opção"/>
                <asp:ListItem Value="1" Text="Cadastrar Cliente"/>
                <asp:ListItem Value="2" Text="Consultar Cliente"/>
                <asp:ListItem Value="3" Text="Obter os dados do cliente"/>

            </asp:DropDownList>

            <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-success btn-lg" OnClick="btnAcessar" />
             
            <p>
                <asp:label ID="lblMensagem" runat="server" />
            </p>

        </div>
    </form>
</body>
</html>