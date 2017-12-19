﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class defaut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessar(object sender, EventArgs e)
        {
            //capturar o  valor selecionado na Drop Down List
            string opcao = ddlMenu.SelectedValue;

            switch (opcao)          
            {
                case "0":
                    lblMensagem.Text = "Por favor, selecione uma opção válida.";
                    break;
                case "1":
                    Response.Redirect("/Pages/cadastro.aspx");
                    break;
                case "2":
                    Response.Redirect("/Pages/Consulta.aspx");
                    break;
                case "3":
                    Response.Redirect("/Pages/Detalhes.aspx");
                    break;

            }
        }
    }
}