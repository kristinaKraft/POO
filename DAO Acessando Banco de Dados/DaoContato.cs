using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeDados.entidade;

namespace BancoDeDados.dao
{
    public class DaoContato
    {

        public bool salvar(Contato contato) 
        {
            using (SqlConnection con = new SqlConnection()) 
                
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bandodedados_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                /*monta comnado DML a ser enviado para o database*/
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from tb_contatos";

                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                dr = cn.ExecuteReader();
                while (dr.Read())
                {
                    Contato ct = new Contato();
                    ct.Id = Convert.ToInt32(dr["id"]);
                    ct.Nome = Convert.ToString(dr["nome"]);
                    ct.Email = Convert.ToString(dr["email"]);
                    ct.Telefone = Convert.ToString(dr["telefone"]);
                    Console.WriteLine(ct.ToString());
                }
            }
        }

    }            
          
}
