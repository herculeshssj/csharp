using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap2_ODBC
{
    class ListaEditora
    {
        public static void execute()
        {
            using(OdbcConnection conexao = ConnectionFactory.CreateConnection()) {
                string textoListaEditora = "select * from Editoras";
                OdbcCommand command = new OdbcCommand(textoListaEditora, conexao);
                conexao.Open();
                OdbcDataReader resultado = command.ExecuteReader();

                while (resultado.Read())
                {
                    long? id = resultado["Id"] as long?;
                    string nome = resultado["Nome"] as string;
                    string email = resultado["Email"] as string;
                    System.Console.WriteLine("{0} : {1} - {2}\n", id,nome,email);
                }
                System.Console.ReadKey();
            }
        }
    }
}
