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
    }
}
