using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace K19_K32_Cap8_Validacao.Models
{
    public class K19Context : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }
    }
}