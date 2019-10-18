using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap2_Logica
{
    class ImprimePadrao1
    {
        public void Execute()
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 2;
                if (resto == 1)
                {
                    System.Console.WriteLine("*");
                }
                else
                {
                    System.Console.WriteLine("**");
                }
            }
        }

        static void Main(string[] args) {
            ImprimePadrao1 padrao1 = new ImprimePadrao1();
            padrao1.Execute();
            System.Console.ReadLine(); 
        }
    }
}