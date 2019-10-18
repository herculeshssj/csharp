using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap2_Logica
{
    class ImprimePadrao3
    {
        public void Execute()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }

        static void Main(string[] args) {
            ImprimePadrao3 padrao3 = new ImprimePadrao3();
            padrao3.Execute();
            System.Console.ReadLine(); 
        }
    }
}