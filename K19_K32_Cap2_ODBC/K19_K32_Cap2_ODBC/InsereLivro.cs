using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap2_ODBC
{
    class InsereLivro
    {
        public static void execute()
        {
            System.Console.Write("Digite o título do livro: ");
            string titulo = System.Console.ReadLine();

            System.Console.Write("Digite o preço do livro: ");
            double preco = Convert.ToDouble(System.Console.ReadLine());

            System.Console.Write("Digite o ID da editora: ");
            int editora = Convert.ToInt16(System.Console.ReadLine());

            string textoInsereEditora = @"insert into Livros (Titulo, Preco, EditoraId) values (?,?,?)";

            using (OdbcConnection conexao = ConnectionFactory.CreateConnection())
            {                
                OdbcCommand command = new OdbcCommand(textoInsereEditora, conexao);

                command.Parameters.AddWithValue("@Titulo", titulo);
                command.Parameters.AddWithValue("@Preco", preco);
                command.Parameters.AddWithValue("@EditoraId", editora);

                conexao.Open();
                command.ExecuteNonQuery();
                System.Console.Write("Registro salvo com sucesso!");
            }
        }
    }
}
