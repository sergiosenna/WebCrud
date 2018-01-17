<%@ Page Title="Detalhes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Obter dados do cliente pelo código</h3>
                <br /> 
                <h4>Informe o Código do Cliente:</h4> 

                <div class="form-inline">
                <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="4%" />               
                <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" CssClass="btn btn-primary" OnClick="btnPesquisarCliente" />
                </div>             
                <br />
                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <asp:Panel Id="pnlDados" runat="server">
                <h6>Nome do Cliente:</h6> 
                <asp:TextBox ID="txtNome" runat="server"  CssClass="form-control" Width="50%" />
                <br />
                <h6>Endereço:</h6> 
                <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" Width="50%" />
                <br />
                <h6>Email:</h6> 
                <asp:TextBox ID="txtEmail" runat="server"  CssClass="form-control" Width="50%" />
                <br />
                
               
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger"  OnClick="btnExcluirCliente"/>
                <asp:Button ID="btnatualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning" OnClick="btnAtualizarCliente" />
                </asp:Panel>

            </div>

        </div>
                
    </div>
</asp:Content>
