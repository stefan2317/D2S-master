using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using D2S.Models;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Threading;

namespace D2S.Controllers
{
    public class HomeController : Controller
    {
        LoginDB db = new LoginDB();

        public IActionResult Index()
        {
            return View("../Home/PT/index");
        }

        [HttpPost]
        public IActionResult Index([Bind] Login log)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = db.Save(log);
                    if (res == "s")
                    {
                        string url = Request.Headers["Referer"].ToString();
                        string textoInvertido = new string(url.Reverse().ToArray());
                        int cont = 0;
                        foreach (char c in textoInvertido)
                        {
                            cont++;
                            if (c == '/')
                            {
                                break;
                            }
                        }
                        string media = textoInvertido.Substring(0, cont - 1);
                        string textoInvertidofinal = new string(media.Reverse().ToArray());                       
                        return RedirectToAction(textoInvertidofinal, "Loged", TempData["nome"] = "verificado");
                    }
                    if (res == "n")
                    {
                        string verificaçao = res;
                        return RedirectToAction("index", "home", TempData["verificaçao"] = verificaçao);
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return RedirectToAction("index", "home");
        }

        public IActionResult Sobre()
        {
            return View("../Home/PT/sobre");
        }

        public IActionResult Encomendar()
        {
            return View("../Home/PT/Encomendar");
        }

        public IActionResult Manutencao()
        {
            return View("../Home/PT/manutencao");
        }

        public IActionResult Registo()
        {
            return View("../Home/PT/registo");
        }

        public IActionResult Contactos()
        {
            return View("../Home/PT/contactos");
        }

        public IActionResult Downloads()
        {
            return View("../Home/PT/Downloads");
        }

        [HttpGet]
        public IActionResult Recrutamento()
        {
            return View("../Home/PT/Recrutamento");
        }

      
    }
}
