using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap3_K19EntityFramework
{
    class InsereAluno
    {
        public static void execute()
        {
            using (var ctx = new K19Context())
            {
                Console.WriteLine("Digite o nome do aluno");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o logradouro do endereço do aluno");
                string logradouro = Console.ReadLine();

                Console.WriteLine("Digite o número do endereço do aluno");
                int numero = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite o CEP do endereço do aluno");
                string cep = Console.ReadLine();

                Aluno a = new Aluno
                {
                    Nome = nome,
                    Endereco = new Endereco
                    {
                        Logradouro = logradouro,
                        Numero = numero,
                        CEP = cep
                    }
                };

                ctx.Alunos.Add(a);
                ctx.SaveChanges();
            }
        }
    }
}
