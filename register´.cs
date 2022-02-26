using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace registration
{
    public class register_
    {
        connection Conexao = new connection();
        SqlCommand com = new SqlCommand();
        public string Mensagem = "";
        public register_(String nome, String telefone)
        {
            com.CommandText = "";

            com.Parameters.AddWithValue("@nome",nome);
            com.Parameters.AddWithValue("@telefone",telefone);

            try
            {
                com.Connection = Conexao.conectar();
                if(com.ExecuteNonQuery()>0)
                  Mensagem = "Cadastro feito com sucesso";
                else
                    Mensagem = "Falha no cadastro";

                Conexao.desconectar();
 
            }
            catch (Exception ex)
            {
                Mensagem = ex.Message; 
            }
                    
        }
    }
}
