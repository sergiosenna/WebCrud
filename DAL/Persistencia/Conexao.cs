using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // ADO.NET -> SQL SERVER

namespace DAL.Persistencia
{
    public class Conexao
    {
        //Atributos
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Métodos - Abrir conexao
        protected void AbrirConexao()
        {
            try 
	        {
                Con = new SqlConnection("Data Source=SERGIO-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                Con.Open();
	        }
	        catch (Exception ex)
	        {

		        throw new Exception(ex.Message);
	        }

        }

        //Método - Fechar Conexao
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
