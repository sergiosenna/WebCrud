<%@ Page Title="S&S - CONSULTA" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
   

    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Consulta de Clientes</h3>
                
                <asp:GridView ID="gridClientes" runat="server"  CssClass="table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#f0f0f0" Width="100%" BorderStyle="Groove" >
                    <Columns>
                       <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                       <asp:BoundField DataField="Nome" HeaderText="Nome" />
                       <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                       <asp:BoundField DataField="Email" HeaderText="Email" />  
                   </Columns>
                    <RowStyle CssClass="cursor-pointer" />
                </asp:GridView>              
                   
                <p>
                    <asp:Label Id="lblMensagen" runat="server" />
                </p>
              
            </div>
            
        </div>


    </div>
   
</asp:Content>

