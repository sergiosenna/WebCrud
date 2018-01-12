using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistencia;

namespace Site.Pages
{
    public partial class Cadastros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCadastrarCliente(object sender, EventArgs e)
        {
            try
            {
               Pessoa p = new Pessoa();

                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;

                PessoaDAL d = new PessoaDAL();
                d.Gravar(p);// gravando os dados

                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;

                lblMensagem.Text = "Cliente, " + p.Nome + ", cadastrado com sucesso!!";

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}