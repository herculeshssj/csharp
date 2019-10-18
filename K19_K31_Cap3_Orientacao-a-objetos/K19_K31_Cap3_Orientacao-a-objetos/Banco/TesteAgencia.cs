using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap3_Orientacao_a_objetos
{
    class TestaAgencia
    {
        static void Main(string[] args)
        {
            Agencia a1 = new Agencia();
            a1.numero = 1234;

            Agencia a2 = new Agencia();
            a2.numero = 5678;

            System.Console.WriteLine(a1.numero);
            System.Console.WriteLine(a2.numero);

            System.Console.ReadLine();
        }
    }
}