using K19_K31_Cap3_Orientacao_a_objetos.Escola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap3_Orientacao_a_objetos
{
    class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario a = new Funcionario();
            a.nome = "Funcioario";
            a.matricula = 24322;
            a.cargo = "Secretário";
            
            System.Console.WriteLine(a.nome);
            System.Console.WriteLine(a.matricula);
            System.Console.WriteLine(a.cargo);

            System.Console.ReadLine();
        }
    }
}