using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19_K32_Cap11_TratamentoDeErros.Controllers
{
    public class TesteController : Controller
    {
        //
        // GET: /Teste/

        public ActionResult TestaErro()
        {
            string[] nomes = new string[] { "Jonas Hirata", "Rafael Consentino" };
            string nome = nomes[2];
            return View();
        }

    }
}
