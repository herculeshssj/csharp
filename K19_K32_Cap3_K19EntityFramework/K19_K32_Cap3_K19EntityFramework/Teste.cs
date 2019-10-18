using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap3_K19EntityFramework
{
    class Teste
    {
        static void _Main(string[] args)
        {
            using (var ctx = new K19Context())
            {

                Aluno a1 = new Aluno
                {
                    Nome = "Amanda Guerra",
                    Endereco = new Endereco
                    {
                        Logradouro = "Rua Amalera",
                        Numero = 1789,
                        CEP = "00157-001"
                    }
                };

                Aluno a2 = new Aluno
                {
                    Nome = "Marcelo Martins",
                    Endereco = new Endereco
                    {
                        Logradouro = "Rua Zaul",
                        Numero = 2907,
                        CEP = "09147-001"
                    }
                };

                Professor p = new Professor
                {
                    Nome = "Jonas Hirata",
                    Endereco = new Endereco
                    {
                        Logradouro = "Rua Mervelha",
                        Numero = 8367,
                        CEP = "00876-100"
                    }
                };

                Turma t = new Turma
                {
                    Vagas = 10,
                    Alunos = new List<Aluno>()
                };

                t.Professor = p;
                t.Alunos.Add(a1);
                t.Alunos.Add(a2);

                ctx.Turmas.Add(t);
                ctx.SaveChanges();
            }
        }
    }
}
