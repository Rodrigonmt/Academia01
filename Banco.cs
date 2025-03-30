using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Academia01
{
    internal class Banco
    {
        public static SQLiteConnection conexao;//criado elemento chamado conexão do tipo SQLiteConnection
        public static SQLiteConnection ConexaoBanco()//criar metodo para conectar banco que retorna um elemento do tipo SQLiteConnection
        {
            conexao = new SQLiteConnection("Data source=C:\\Users\\Rodrigo\\Desktop\\Projeto\\Academia01\\banco\\Banco_dados");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "select *from tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }

            
        }

    }
}
