using ExemploValidacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            /*
            if (string.IsNullOrEmpty(pessoa.Nome))
            {
                ModelState.AddModelError("Nome","O campo é obrigatório");
            }
            if (pessoa.Senha != pessoa.ConfirmaSenha)
            {
                ModelState.AddModelError("","As senhas não conferem");
            }
            */
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }
            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}