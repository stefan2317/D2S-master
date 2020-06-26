using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using D2S.Models;
using D2S.DataBase;

namespace D2S.Controllers
{
    public class EmpController : Controller
    {
        private readonly DB _cc;

        public EmpController(DB cc)
        {
            _cc = cc;
        }
        public IActionResult Index()
        {
            var result = _cc.chat.ToList();
            return View(result);
        }
    }
}