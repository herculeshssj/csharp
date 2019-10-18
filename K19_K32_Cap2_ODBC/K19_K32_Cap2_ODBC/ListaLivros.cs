using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap2_ODBC
{
    class ListaLivros
    {
        public static void execute()
        {
            using (OdbcConnection conexao = ConnectionFactory.CreateConnection())
            {
                string textoListaLivro = "select * from Livros";
                OdbcCommand command = new OdbcCommand(textoListaLivro, conexao);
                conexao.Open();
                OdbcDataReader resultado = command.ExecuteReader();

                while (resultado.Read())
                {
                    long? id = resultado.GetInt16(0);
                    string titulo = resultado.GetString(1);
                    float preco = resultado.GetFloat(2);
                    int editora = resultado.GetInt16(3);
                    System.Console.WriteLine("{0} : {1} - {2} - {3}\n", id, titulo,preco,editora);
                }
                System.Console.ReadKey();
            }
        }
    }
}
