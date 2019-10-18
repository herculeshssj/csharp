using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap3_K19EntityFramework
{
    class RemoveAluno
    {
        public static void execute()
        {
            using (var ctx = new K19Context())
            {
                var consulta = from a in ctx.Alunos select a;

                foreach (Aluno a in consulta)
                {
                    Console.WriteLine("Aluno: {0} - {1}", a.AlunoID, a.Nome);
                }
                Console.WriteLine("------------------------------------");

                Console.WriteLine("Informe o ID do aluno");
                int alunoID = Int32.Parse(Console.ReadLine());

                Aluno aluno = ctx.Alunos.Find(alunoID);

                ctx.Alunos.Remove(aluno);

                ctx.SaveChanges();
            }
        }
    }
}
