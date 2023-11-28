using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.dao
{
    public class DaoLocais
    {
        public bool salvar(Locais locais) 
        {
            using (SqlConnection lc = new SqlConnection()) 
            {
                /*criado conexão com database*/
                lc.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bandodedados_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                /*monta comnado DML a ser enviado para o database*/
                SqlCommand lc = new SqlCommand();
                lc.CommandType = CommandType.Text;
                lc.CommandText = "insert into tb_locais([nome],[rua],[numero],[cidade],[UF])values(@nome,@rua,@numero,@cidade,@UF)";

                /*envia os dados a serem gravados*/
                lc.Parameters.Add("nome", SqlDbType.VarChar).Value = locais.Nome;
                lc.Parameters.Add("rua", SqlDbType.VarChar).Value = locais.Rua;
                lc.Parameters.Add("numero", SqlDbType.VarChar).Value = locais.Numero;
                lc.Parameters.Add("cidade", SqlDbType.VarChar).Value = locais.Cidade;
                lc.Parameters.Add("UF", SqlDbType.VarChar).Value = locais.UF;
                


                /*abrir a conexão*/
                lc.Open();
                lc.Connection = lc;


                /*executa a conexão*/
                return lc.ExecuteNonQuery() > 0;
            }
        }
    }
}
