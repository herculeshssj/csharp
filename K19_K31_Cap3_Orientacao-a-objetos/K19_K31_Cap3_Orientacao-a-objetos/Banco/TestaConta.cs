using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap3_Orientacao_a_objetos
{
    class TestaConta
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.numero = 1234;
            c1.saldo = 1000;
            c1.limite = 500;

            Conta c2 = new Conta();
            c2.numero = 5678;
            c2.saldo = 2000;
            c2.limite = 250;

            System.Console.WriteLine(c1.numero);
            System.Console.WriteLine(c1.saldo);
            System.Console.WriteLine(c1.limite);

            System.Console.WriteLine(c2.numero);
            System.Console.WriteLine(c2.saldo);
            System.Console.WriteLine(c2.limite);

            System.Console.ReadLine();
        }
    }
}