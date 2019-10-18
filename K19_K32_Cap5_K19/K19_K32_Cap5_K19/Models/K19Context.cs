using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace K19_K32_Cap5_K19.Models
{
    public class K19Context : DbContext
    {
        public DbSet<Editora> Editoras { get; set; }

        public DbSet<Livro> Livros { get; set; }
    }
}