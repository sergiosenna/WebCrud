<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastros" %>

   
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well" >Cadastro de Clientes</h3>
                    <br />

                    <h4> Nome do Cliente:</h4>
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome completo" Width="50%" CssClass="form-control"/>
                    <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Por favor, Informe seu nome." ForeColor="Red"/>
                    <br />

                    <h4>Endereço do Cliente:</h4>
                    <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial" Width="50%" CssClass="form-control"/>
                    <asp:RequiredFieldValidator 
                        ID="requiredEndereco" runat="server" ControlToValidate="txtEndereco" ErrorMessage="Por favor, Informe seu endereço." ForeColor="Red"/>
                    <br />

                    <h4> Email:</h4>                   
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" Width="50%" CssClass="form-control"/>
                    <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Por favor, Informe seu email." ForeColor="Red"/>
                    <br />

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                    
                    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnCadastrarCliente" />

                </div>                
            </div>
        </div>
</asp:Content>
