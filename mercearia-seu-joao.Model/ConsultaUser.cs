using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mercearia_seu_joao.Model
{
    public class ConsultaUser
    {
         public static bool ConsultarUser(string nome, string email, string senha, string tipoUsuario)
        {
            var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
            UsuarioBD usuario = null;

            try
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = @"SELECT * FROM Usuario WHERE email = @email AND senha = @senha";
                var leitura = comando.ExecuteReader();
                while (leitura.Read())
                {
                    usuario = new UsuarioBD();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            return true;
        }
    }
}
