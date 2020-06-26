using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using D2S.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace D2S.Controllers
{
    public class MensagemController : Controller
    {

        EnvioMensagem dbop = new EnvioMensagem();

        [HttpPost]
        public IActionResult mensagem([Bind] Mensagem emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = dbop.Enviar(emp);
                    TempData["msg"] = res;
                }
                else
                {                    
                    return View("../Home/PT/Contactos");
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }

            return View("../Home/PT/Contactos");

        }
    }
}
