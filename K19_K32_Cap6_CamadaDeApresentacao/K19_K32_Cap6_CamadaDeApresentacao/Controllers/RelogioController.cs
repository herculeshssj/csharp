using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19_K32_Cap6_CamadaDeApresentacao.Controllers
{
    public class RelogioController : Controller
    {
        //
        // GET: /Relogio/

        public ActionResult Index()
        {
            ViewBag.Agora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            return View();
        }

    }
}
