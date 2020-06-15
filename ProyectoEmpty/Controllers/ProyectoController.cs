using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace ProyectoEmpty.Controllers
{
    public class ProyectoController : Controller
    {
        public ActionResult Listado()
        {
            var service = new WebService.WebServiceNecesidadesSoapClient();
            var lista = service.get();
            return View(lista);
        }
    }
}