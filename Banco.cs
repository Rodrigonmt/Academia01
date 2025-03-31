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
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex) 
            {
                ConexaoBanco().Close();
                throw ex;
            }

            
        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }

        //////Funções do FORM F_NovoUsuario
        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username já existe!");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "insert into tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) values (@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário Inserido com Sucesso!");
                ConexaoBanco().Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao gravar novo usuário");
                ConexaoBanco().Close();
            }
        }
        
        //////Fim da Função F_NovoUsuario
        
        
        //////Rotinas Gerais
        public static bool existeUsername(Usuario u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "select T_USERNAME from tb_usuarios where T_USERNAME='"+u.username+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res= true;
            }
            else
            {
                res= false;
            }
            ConexaoBanco().Close();
            return res;
        }


    }
}
