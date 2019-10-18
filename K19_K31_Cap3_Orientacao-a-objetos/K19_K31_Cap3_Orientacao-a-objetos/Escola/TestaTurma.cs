using K19_K31_Cap3_Orientacao_a_objetos.Escola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap3_Orientacao_a_objetos
{
    class TestaTurma
    {
        static void Main(string[] args)
        {
            Turma a = new Turma();
            a.periodo = 1;
            a.serie = 5;
            a.sigla = "AAK";
            a.tipoDeEnsino = "Fundamental";

            System.Console.WriteLine(a.periodo);
            System.Console.WriteLine(a.serie);
            System.Console.WriteLine(a.sigla);
            System.Console.WriteLine(a.tipoDeEnsino);

            System.Console.ReadLine();
        }
    }
}