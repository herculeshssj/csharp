using K19_K32_Cap6_CamadaDeApresentacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19_K32_Cap6_CamadaDeApresentacao.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        public ActionResult Editar()
        {
            Usuario usuario = new Usuario
            {
                Id = 1,
                Nome = "Rafael Cosentino",
                Email = "rafael@k19.com.br",
                Senha = "123",
                Descricao = "Sócio-fundador da K19 / Instrutor",
                DataDeCadastro = DateTime.Now
            };
            return View(usuario);
        }

    }
}
