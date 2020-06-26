using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace D2S.Controllers
{
    public class EncomendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}