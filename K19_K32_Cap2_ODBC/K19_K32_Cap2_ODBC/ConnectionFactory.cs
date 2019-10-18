using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap2_ODBC
{
    class ConnectionFactory
    {
        public static OdbcConnection CreateConnection()
        {
            string driver = @"SQL Server";
            string servidor = @"WIN7HP-PC\SQLEXPRESS";
            string baseDeDados = @"livraria";
            string usuario = @"sa";
            string senha = @"sudoUser1234!";

            StringBuilder connectionString = new StringBuilder();
            connectionString.Append("driver=");
            connectionString.Append(driver);
            connectionString.Append(";server=");
            connectionString.Append(servidor);
            connectionString.Append(";database=");
            connectionString.Append(baseDeDados);
            connectionString.Append(";uid=");
            connectionString.Append(usuario);
            connectionString.Append(";pwd=");
            connectionString.Append(senha);

            return new OdbcConnection(connectionString.ToString());
        }
    }
}
