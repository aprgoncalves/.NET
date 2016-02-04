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
        // GET: Home
        public ActionResult Index(CadastroModel cadastro)
        {
            return View(cadastro);
        }

        public ActionResult Sobre()
        {
            return View();
        }

    }
}