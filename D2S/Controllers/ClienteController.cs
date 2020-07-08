using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D2S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace D2S.Controllers
{

    public class ClienteController : Controller
    {

        [HttpGet]
        public IActionResult Registo()
        {           
            ViewBag.ver = null;
            return View("../Home/PT/registo");
        }

        
       
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult registo([Bind]Cliente emp)
        {
            EnvioCliente dbop = new EnvioCliente();
            try
            {
                if (ModelState.IsValid)
                {
                    string res = dbop.addcliente(emp);
                    TempData["msg"] = res;
                    
                }
                else
                {                   
                    return View("../Home/PT/Registo",emp);
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }

            return View("../Home/PT/Registo");
        }

        [HttpPost]
        public ViewResult ver([Bind] Cliente emp)
        {
            if (ModelState.IsValid)
            {
                ViewBag.nome = emp.nome;
                ViewBag.telemovel = emp.telefone;
                ViewBag.email = emp.email;
                ViewBag.sexo = emp.sexo;
                ViewBag.datadenascimento = emp.datadenascimento;
                ViewBag.nif = emp.nif;
                ViewBag.pass = emp.pass;
                ViewBag.confpass = emp.confpass;
                ViewBag.ver = "sim";
                return View("../Home/PT/Registo"); 
            }
            else
            {
                ViewBag.nome = emp.nome;
                ViewBag.telemovel = emp.telefone;
                ViewBag.email = emp.email;
                ViewBag.sexo = emp.sexo;
                ViewBag.datadenascimento = emp.datadenascimento;
                ViewBag.nif = emp.nif;
                ViewBag.pass = emp.pass;
                ViewBag.confpass = emp.confpass;
                ViewBag.ver = null;
                return View("../Home/PT/Registo");
            }
            
         }

        [HttpPost]
        public ViewResult ver2()
        {
           
            if (ModelState.IsValid)
            {               
                ViewBag.ver = "3";
                return View("../Home/PT/Registo");
            }
            else
            {
                ViewBag.ver = "sim";
                return View("../Home/PT/Registo");
            }

        
        }
    }

}

    

    //EnvioMensagem dbop = new EnvioMensagem();

    //[HttpPost]
    //public IActionResult mensagem([Bind] Mensagem efgfg)
    //{
    //    try
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            string res = dbop.Enviar(emp);
    //            TempData["msg"] = res;
    //        }
    //        else
    //        {
    //            return View("../Home/PT/Contactos");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        TempData["msg"] = ex.Message;
    //    }

    //    return View("../Home/PT/Contactos");

    //}

