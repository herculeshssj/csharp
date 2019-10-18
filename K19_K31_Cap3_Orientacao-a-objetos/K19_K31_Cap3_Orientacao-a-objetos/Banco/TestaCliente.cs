using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K31_Cap3_Orientacao_a_objetos
{
    class TestaCliente
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.nome = "Rafael Consentino";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = "Jonas Hirata";
            c2.codigo = 2;

            System.Console.WriteLine(c1.nome);
            System.Console.WriteLine(c1.codigo);

            System.Console.WriteLine(c2.nome);
            System.Console.WriteLine(c2.codigo);
            System.Console.ReadLine();
        }
    }
}