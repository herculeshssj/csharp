﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K19_K32_Cap9_Sessao.Models
{
    public class Carrinho
    {
        public List<Produto> Produtos { get; set; }

        public Carrinho()
        {
            this.Produtos = new List<Produto>();
        }
    }
}