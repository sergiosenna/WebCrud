using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;


// Regras de negócio da aplicação - Consultas 
// SELECT, UPDATE, INSERT , DELETE , OBTERPORID

namespace DAL.Persistencia
{
    public class PessoaDAL : Conexao
    {
        //Método para gravar os dados : INSERT
        public void Gravar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Pessoa (Nome, Endereco, Email) values (@nome, @endereco ,@email)",Con);
                Cmd.Parameters.AddWithValue("@nome", p.Nome);
                Cmd.Parameters.AddWithValue("@endereco", p.Endereco);
                Cmd.Parameters.AddWithValue("@email", p.Email);

                Cmd.ExecuteNonQuery();//Executa o método !
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar os dados: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        //Método para atualizar os Dados : UPDATE
        public  void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Pessoa set Nome=@nome, Endereco=@endereco, Email=@email where Codigo=@codigo", Con);
                Cmd.Parameters.AddWithValue("@nome", p.Nome);
                Cmd.Parameters.AddWithValue("@endereco", p.Endereco);
                Cmd.Parameters.AddWithValue("@email", p.Email);
                Cmd.Parameters.AddWithValue("@codigo", p.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar os dados: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        //Método para excluir os Dados : DELETE
        public void Excluir(int codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Pessoa where Codigo=@codigo", Con);
                Cmd.Parameters.AddWithValue("@codigo",codigo);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir os dados: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para obter Pessoa pelo  Codigo (chave Primaria )
        public Pessoa PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa where Codigo=@codigo",Con);
                Cmd.Parameters.AddWithValue("@codigo", Codigo);

                Pessoa p = null; // criando um espaco de memória:

                if (Dr.Read())
                {
                    p = new Pessoa();

                    p.Codigo    = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome      = Convert.ToString(Dr["Nome"]);
                    p.Endereco  = Convert.ToString(Dr["Codigo"]);
                    p.Email     = Convert.ToString(Dr["Email"]);
                }

                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar os dados: "  + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para listar todoos os dados cadastrados
        public List<Pessoa> Lista()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa", Con);
                Dr = Cmd.ExecuteReader();

                List<Pessoa> Lista = new List<Pessoa>();// lista vazia

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Codigo"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                }

                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar os dados:" + ex.Message);
            }finally
            {
                FecharConexao();
            }
        }
    }

    
}
