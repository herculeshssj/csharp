using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap2_ODBC
{
    class Program
    {
        public static void Main(string[] args)
        {
            InsereEditora.execute();            
            ListaEditora.execute();
            InsereLivro.execute();
            ListaLivros.execute();
        }
    }
}
