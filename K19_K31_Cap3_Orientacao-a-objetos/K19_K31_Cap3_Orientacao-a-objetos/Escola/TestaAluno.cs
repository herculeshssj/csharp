using K19_K31_Cap3_Orientacao_a_objetos.Escola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap3_Orientacao_a_objetos
{
    class TestaAluno
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "Aluno";
            a.rg = 12312123;
            a.dataNascimento = "01/01/1994";

            System.Console.WriteLine(a.nome);
            System.Console.WriteLine(a.rg);
            System.Console.WriteLine(a.dataNascimento);

            System.Console.ReadLine();
        }
    }
}