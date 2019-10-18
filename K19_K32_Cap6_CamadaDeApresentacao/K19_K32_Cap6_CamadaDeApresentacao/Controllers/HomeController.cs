using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19_K32_Cap6_CamadaDeApresentacao.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Random random = new Random();
            ViewBag.NumeroDaSorte = random.Next();
            return View();
        }

    }
}
