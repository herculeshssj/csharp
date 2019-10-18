using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace K19_K32_Cap9_Sessao.Models
{
    public class K19Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }    
    }
}