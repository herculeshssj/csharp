using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap3_Orientacao_a_objetos
{
    class TestaValoresPadrao
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            
            System.Console.WriteLine(c1.numero);
            System.Console.WriteLine(c1.saldo);
            System.Console.WriteLine(c1.limite);

            System.Console.ReadLine();
        }
    }
}