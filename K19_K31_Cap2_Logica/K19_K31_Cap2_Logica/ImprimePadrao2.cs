using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap2_Logica
{
    class ImprimePadrao2
    {
        public void Execute()
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 4;
                if (resto == 0)
                {
                    System.Console.WriteLine("PI");
                }
                else
                {
                    System.Console.WriteLine(contador);
                }
            }
        }

        static void Main(string[] args) {
            ImprimePadrao2 padrao2 = new ImprimePadrao2();
            padrao2.Execute();
            System.Console.ReadLine(); 
        }
    }
}