﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistencia;

namespace Site.Pages
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }
        // Ação do Botão Pesquisar
        protected void btnPesquisarCliente(object sender, EventArgs e)
        {
            try
            {
               
                int codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL d = new PessoaDAL();
                Pessoa p = d.PesquisarPorCodigo(codigo);

                if (p != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                    txtEndereco.Text = p.Endereco;
                    txtEmail.Text = p.Email;
                    

                }
                else
                {
                    lblMensagem.Text = "Cliente não encontrado!";
                    txtCodigo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
        //Ação do Botão Excluir
        protected void btnExcluirCliente(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                Pessoa p = new Pessoa();
                PessoaDAL d = new PessoaDAL();

                d.Excluir(Codigo);

                lblMensagem.Text = "Cliente Excluído com SUcesso!";

                txtCodigo.Text      = string.Empty;
                txtNome.Text        = string.Empty;
                txtEndereco.Text    = string.Empty;
                txtEmail.Text       = string.Empty;

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
        //Ação do Botão Atualizar Cliente
        protected void btnAtualizarCliente(object sender, EventArgs e)
        {
            try
            {

                Pessoa p = new Pessoa();
               

                p.Codigo = Convert.ToInt32(txtCodigo.Text);
                p.Nome = Convert.ToString(txtNome.Text);
                p.Endereco = Convert.ToString(txtEndereco.Text);
                p.Email = Convert.ToString(txtEmail.Text);

                PessoaDAL d = new PessoaDAL();

                d.Atualizar(p);

                lblMensagem.Text = "Cliente atualizado com Sucesso!";

                txtCodigo.Text      = string.Empty;
                txtNome.Text        = string.Empty;
                txtEndereco.Text    = string.Empty;
                txtEmail.Text       = string.Empty;

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

    }
}