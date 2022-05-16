using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using LN;

namespace PRESENTACION.Controllers
{
    public class MarcasController : Controller
    {

        // GET: Marcas


        MarcaLN marcaln = new MarcaLN();
        public ActionResult Index()
        {
            return View(marcaln.ListadoMarcas());
        }
    }
}