using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap3_Orientacao_a_objetos
{
    class TestaCartaoDeCredito
    {
        static void Main(string[] args)
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 11111111;
            cdc1.dataDeValidade = "01/01/2013";

            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 22222222;
            cdc2.dataDeValidade = "01/01/2014";

            System.Console.WriteLine(cdc1.numero);
            System.Console.WriteLine(cdc1.dataDeValidade);

            System.Console.WriteLine(cdc2.numero);
            System.Console.WriteLine(cdc2.dataDeValidade);

            System.Console.ReadLine();
        }
    }
}