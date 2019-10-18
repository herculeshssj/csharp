using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap2_Logica
{
    class ImprimePadrao5
    {
        public void Execute()
        {
            int numeroAnterior = 0;
            int numeroAtual = 0;
            for (int i = 0; i < 30; i++)
            {
                int resultado = numeroAnterior + numeroAtual;

                System.Console.WriteLine(resultado);

                numeroAnterior = numeroAtual;
                if (resultado == 0)
                    resultado++;
                numeroAtual = resultado;
            }
        }

        static void Main(string[] args) {
            ImprimePadrao5 padrao5 = new ImprimePadrao5();
            padrao5.Execute();
            System.Console.ReadLine(); 
        }
    }
}