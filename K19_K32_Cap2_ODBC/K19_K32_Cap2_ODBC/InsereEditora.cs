using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap2_ODBC
{
    class InsereEditora
    {
        public static void execute()
        {
            System.Console.Write("Digite o nome da editora: ");
            string nome = System.Console.ReadLine();

            System.Console.Write("Digite o e-mail da editora: ");
            string email = System.Console.ReadLine();

            string textoInsereEditora = @"insert into Editoras (Nome, Email) values (?,?)";

            using (OdbcConnection conexao = ConnectionFactory.CreateConnection()) {
                OdbcCommand command = new OdbcCommand(textoInsereEditora, conexao);

                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Email", email);

                conexao.Open();
                command.ExecuteNonQuery();
                System.Console.Write("Registro salvo com sucesso!");
            }
        }
    }
}
