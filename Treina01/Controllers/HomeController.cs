using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treina01.Models;

namespace Treina01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(CadastroModel cadastro)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Obrigado", cadastro);
            }
            else
            {
                return View(cadastro);
            }
        }

        public ActionResult Obrigado(CadastroModel cadastro)
        {
            return View(cadastro);
        }

    }
}