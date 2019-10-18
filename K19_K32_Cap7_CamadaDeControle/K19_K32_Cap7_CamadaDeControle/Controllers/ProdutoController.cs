using K19_K32_Cap7_CamadaDeControle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19_K32_Cap7_CamadaDeControle.Controllers
{
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/

        public ActionResult Lista(double? precoMinimo, double? precoMaximo)
        {
            K19Context ctx = new K19Context();
            var produtos = ctx.Produtos.AsEnumerable();

            if (precoMinimo != null && precoMaximo != null)
            {
                produtos = from p in produtos 
                           where p.Preco >= precoMinimo & p.Preco <= precoMaximo 
                           select p;
            }

            return View(produtos);
        }

        [HttpGet]
        public ActionResult Cadastra()
        {
            return View();
        }

        public ActionResult Cadastra(Produto p)
        {
            /*
            Produto p = new Produto
            {
                Nome = nome,
                Descricao = descricao,
                Preco = preco
            };
            */
            K19Context ctx = new K19Context();
            ctx.Produtos.Add(p);
            ctx.SaveChanges();

            TempData["Mensagem"] = "Produto cadastrado com sucesso!";

            return RedirectToAction("Lista");
        }

        public ActionResult Editar(int id = 0)
        {
            K19Context ctx = new K19Context();
            Produto p = ctx.Produtos.Find(id);

            if (p == null)
            {
                return HttpNotFound();
            }

            return View(p);
        }

        [HttpPost]
        public ActionResult Editar(Produto p)
        {
            K19Context ctx = new K19Context();
            ctx.Entry(p).State = System.Data.EntityState.Modified;
            ctx.SaveChanges();

            return RedirectToAction("Lista");
        }
    }
}
