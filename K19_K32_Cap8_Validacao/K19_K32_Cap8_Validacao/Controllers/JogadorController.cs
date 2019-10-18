using K19_K32_Cap8_Validacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19_K32_Cap8_Validacao.Controllers
{
    public class JogadorController : Controller
    {
        //
        // GET: /Jogador/

        public ActionResult Lista()
        {
            K19Context ctx = new K19Context();
            return View(ctx.Jogadores);
        }

        [HttpGet]
        public ActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]  
        public ActionResult Cadastra(Jogador j)
        {
            if (ModelState.IsValid)
            {
                K19Context ctx = new K19Context();
                ctx.Jogadores.Add(j);
                ctx.SaveChanges();
                return RedirectToAction("Lista");
            }
            else
            {
                return View("Cadastra", j);
            }            
        }
    }
}
