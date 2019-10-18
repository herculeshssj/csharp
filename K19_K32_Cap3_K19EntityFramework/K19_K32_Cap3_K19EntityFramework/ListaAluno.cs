using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap3_K19EntityFramework
{
    class ListaAluno
    {
        public static void execute()
        {
            using (var ctx = new K19Context())
            {
                var consulta = from a in ctx.Alunos select a;

                foreach (Aluno a in consulta)
                {
                    Console.WriteLine("Nome: " + a.Nome);
                    Console.WriteLine("Logradouro: " + a.Endereco.Logradouro);
                    Console.WriteLine("Nome: " + a.Endereco.Numero);
                    Console.WriteLine("Nome: " + a.Endereco.CEP);
                    Console.WriteLine("------------------------------------");
                }
            }
        }
    }
}
