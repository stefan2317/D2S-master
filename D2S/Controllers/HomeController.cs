using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace D2S.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("../Home/PT/index");
        }

        public IActionResult Sobre()
        {
            return View("../Home/PT/sobre");
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
