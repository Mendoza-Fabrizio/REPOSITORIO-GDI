using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ORDEN_COMPRA.Models;
namespace ORDEN_COMPRA.Controllers
{
    public class DatosCompraController : Controller
    {
        // GET: DatosCompra
        public ActionResult Index()
        {
            return View();
        }
    }
}