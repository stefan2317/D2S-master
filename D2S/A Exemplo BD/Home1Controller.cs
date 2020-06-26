using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using D2S.Models;

namespace D2S.Controllers
{
    public class Home1Controller : Controller
    {
        private readonly ILogger<Home1Controller> _logger;
        Menssagem dbop = new Menssagem();

        public Home1Controller(ILogger<Home1Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([Bind] EmpClass emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = dbop.Save(emp);
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