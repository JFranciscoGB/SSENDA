using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using LN;
namespace PRESENTACION.Controllers
{
    public class CotizadorController : Controller
    {
        ClienteSofconLN clienteLN = new ClienteSofconLN();
        // GET: Cotizador
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarClientes()
        {
            return View(clienteLN.ListadoClientes());
        }


        public ActionResult Visor()
        {
            return View();
        }

        public ActionResult ListarCotizaciones()
        {
            return View();
        }
    }
}