using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K19_K32_Cap6_CamadaDeApresentacao.Models
{
    public class Post
    {
        public string Autor { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Texto { get; set; }
    }
}