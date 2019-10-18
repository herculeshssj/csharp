using K19_K32_Cap10_Autenticacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace K19_K32_Cap10_Autenticacao.Controllers
{
    public class AutenticadorController : Controller
    {
        //
        // GET: /Autenticador/

        public ActionResult Formulario()
        {
            return View();
        }

        public ActionResult Entrar(Usuario usuario)
        {
            if (usuario.Username != null && usuario.Password != null && usuario.Username.Equals("K19") && usuario.Password.Equals("K19"))
            {
                FormsAuthentication.SetAuthCookie(usuario.Username, false);
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                ViewBag.Mensagem = "Usuário ou senha incorretos";
                return View("Formulario");
            }
        }

        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Formulario");
        }
    }
}
