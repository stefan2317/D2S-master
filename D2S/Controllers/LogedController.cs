using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D2S.Models;
using Microsoft.AspNetCore.Mvc;

namespace D2S.Controllers
{
    public class LogedController : Controller
    {
        Encomenda enc = new Encomenda();

        public IActionResult Index()
        {
            if (TempData["nome"] == null)
            {
                TempData["erro de login"] = "Terá de fazer o login para poder aceder a esta página.";
                return RedirectToAction("index", "home", TempData["erro de login"]);
            }
            return View();
        }
        public IActionResult Downloads()
        {
            return View();
        }

        public IActionResult Prefil()
        {
            return View();
        }

        public IActionResult Encomendar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Encomendar([Bind] FazerEncomenda fzr)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = enc.Save(fzr);
                    TempData["msg"] = res;
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }

        public IActionResult SessaoTerminada()
        {
            TempData["nome"] = null;
            return View();
        }

        public IActionResult Contactos()
        {
            return View("../Loged/Contactos");
        }
    }
}
