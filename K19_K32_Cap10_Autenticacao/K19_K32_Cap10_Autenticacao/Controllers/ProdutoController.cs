using K19_K32_Cap10_Autenticacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19_K32_Cap10_Autenticacao.Controllers
{
    public class ProdutoController : Controller
    {
        private K19Context db = new K19Context();
        //
        // GET: /Produto/

        public ActionResult Index()
        {
            return View(db.Produtos.ToList());
        }
        [Authorize]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produto);
        }
    }
}
