using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace D2S.Controllers
{
    public class LogedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Downloads()
        {
            return View();
        }
    }
}
