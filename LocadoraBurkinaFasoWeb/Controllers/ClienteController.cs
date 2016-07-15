using LocadoraBurkinaFasoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraBurkinaFasoWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        [HttpGet]
        public ActionResult Cadastro_Cliente()
        {
            

            return View();
        }

        // Fazer implementação com HTTPPOST


    }
}