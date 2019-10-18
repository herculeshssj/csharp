using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace K19_K31_Cap2_Logica
{
    class GeradorDePadroes
    {
        static void Main(string[] args)
        {
            // Declaração dos objetos que representam os padrões
            ImprimePadrao1 padrao1 = new ImprimePadrao1();
            ImprimePadrao2 padrao2 = new ImprimePadrao2();
            ImprimePadrao3 padrao3 = new ImprimePadrao3();
            ImprimePadrao4 padrao4 = new ImprimePadrao4();
            ImprimePadrao5 padrao5 = new ImprimePadrao5();

            int opcao = 1; // Temos que atribuir o valor 1 na variável, para poder entrar no laço de repetição
            while (opcao != 0) {
                // Coloque o código do menu aqui.
                System.Console.WriteLine("Gerador de padrões");
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine("Escolha a opção desejada:");
                System.Console.WriteLine("1 - Padrão");
                System.Console.WriteLine("2 - Padrão");
                System.Console.WriteLine("3 - Padrão");
                System.Console.WriteLine("4 - Padrão");
                System.Console.WriteLine("5 - Padrão");
                System.Console.WriteLine("0 - Sair");
                
                // Vamos aprender mais pra frente que esses são os comandos para receber e guardar algum valor da tela.
                TextReader textReader = Console.In;
                string valorTela = textReader.ReadLine();
                opcao = Convert.ToInt32(valorTela);

                if (opcao == 1) {
                    // Código para o padrão 1
                    padrao1.Execute();
                } else if (opcao == 2) {
                    // Código para o padrão 2
                    padrao2.Execute();
                } else if (opcao == 3) {
                    // Código para o padrão 3
                    padrao3.Execute();
                } else if (opcao == 4) {
                    // Código para o padrão 4
                    padrao4.Execute();
                } else if (opcao == 5) {
                    // Código para o padrão 5
                    padrao5.Execute();
                }
            }

        }
    }
}