using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap2_Logica
{
    class Programa
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++) {
                System.Console.WriteLine(args[i]);
            }
            System.Console.ReadLine();
        }

        void declaracaoVariaveis()
        {
            // Declaração de Variáveis

            // Uma variável do tipo int chamado numeroDaConta
            int numeroDaConta;

            // Uma variável do tipo double chamado precoDoProduto
            double precoDoProduto;
        }

        void declarandoQualquerLinhaDeBloco() {
            // Declaração com Inicialização
            int numero = 10;

            // Uso da variável
            System.Console.WriteLine(numero);

            // Outra declaração com inicialização
            double preco = 137.6;

            // Uso da variável
            System.Console.WriteLine(preco);
        }

        void duasVariaveisMesmoNomeNoBloco() {
            // Declaração
            int numero = 10;

            // Erro de compilação
            //int numero = 10;
            // Descomentar a linha acima
        }

        void inicializacao() {
            // Declarações
            int numero;
            double preco;

            // Inicialização
            numero = 10;

            // Uso correto
            System.Console.WriteLine(numero);

            // Erro de compilação
            //System.Console.WriteLine(preco);
            // Descomentar a linha acima
        }

        void tiposPrimitivos() {
            sbyte a = 1;
            byte b = 1;

            short c = 10;
            ushort d = 10;

            int e = 100;
            uint f = 100;

            long g = 1000;
            ulong h = 1000;

            float i = 100.0f;
            double j = 100.0;

            decimal k = 100.12345M;

            bool l = true;

            char m = 'a';
        }

        void operadoresAritmeticos() {
            int umMaisUm = 1 + 1; //umMaisUm = 2
            int tresVezesDois = 3 * 2; // tresVezesDois = 6
            int quatroDivididoPor2 = 4 / 2; // quatroDivididoPor2 = 2
            int seisModuloCinco = 6 % 5; // seisModuloCinco = 1
            int x = 7;

            x = x + 1 * 2; // x = 9
            x = x - 3; // x = 6
            x = x / (6 - 2 + (3 * 5) / (16 - 1)); // x = 2
        }

        void operadoresAtribuicao() {
            int valor = 1; // valor = 1
            valor += 2; // valor = 3
            valor -= 1; // valor = 2
            valor *= 6; // valor = 12
            valor /= 3; // valor = 4
            valor %= 3; // valor = 1
        }

        void operadoresRelacionais() {
            int valor = 2;
            bool t = false;

            t = (valor == 2); // t = true
            t = (valor != 2); // t = false
            t = (valor < 2); // t = false
            t = (valor <= 2); // t = true
            t = (valor > 1); // t = true
            t = (valor >= 1); // t = true
        }

        void operadoresLogicos() {
            int valor = 30;
            bool teste = false;

            teste = valor < 40 && valor > 20; // teste = true
            teste = valor < 40 && valor > 30; // teste = false
            teste = valor > 30 || valor > 20; // teste = true
            teste = valor > 30 || valor < 20; // teste = false
            teste = valor < 50 && valor == 30; // teste = true
        }

        void comandoIf() {
            int preco = 1;
            if (preco < 0) {
                System.Console.WriteLine("O preço do produto não pode ser negativo.");
            } else {
                System.Console.WriteLine("Produto cadastrado com sucesso.");
            }
        }

        void comandoWhile() {
            int contador = 0;
            while (contador < 100) {
                System.Console.WriteLine("Bom Dia!");
                contador++;
            }
        }

        void comandoFor() {
            for (int contador = 0; contador < 100; contador++) {
                System.Console.WriteLine("Bom Dia!");
            }
        }
    }
}