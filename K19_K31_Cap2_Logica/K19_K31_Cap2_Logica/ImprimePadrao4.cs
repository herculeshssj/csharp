using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap2_Logica
{
    class ImprimePadrao4
    {
        public void Execute()
        {
            int contador = 0;
            do
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        System.Console.Write("*");
                    }
                    System.Console.WriteLine();
                }
                contador++;
            }
            while (contador < 10);
        }

        static void Main(string[] args) {
            ImprimePadrao4 padrao4 = new ImprimePadrao4();
            padrao4.Execute();
            System.Console.ReadLine(); 
        }
    }
}