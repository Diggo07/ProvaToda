using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mercearia_seu_joao.Model
{
    public static class ConexaoBD
    {
        public static MySqlConnectionStringBuilder Connection
        {
            get 
            {
                return new MySqlConnectionStringBuilder
                {
                    Server = "192.168.56.1",
                    UserID = "root",
                    Password = "",
                    Database = "mercearia"
                };

            }
            private set { }
        }
    }
}
