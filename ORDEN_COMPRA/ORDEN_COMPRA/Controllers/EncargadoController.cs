using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ORDEN_COMPRA.Models;
namespace ORDEN_COMPRA.Controllers
{
    public class EncargadoController : Controller
    {
        // GET: Encargado
        public ActionResult Index()
        {
            using(var bd = new OrdenCompraEntities())
            {
                List<EncargadoCLS> listaEncargado = null;
                listaEncargado = (from encargado in bd.ENCARGADO
                                  select new EncargadoCLS
                                  {
                                      ruccliente= encargado.RUC_cliente,
                                      nombreempresa=encargado.nombre_Empresa,
                                      padron = encargado.padron
                                  }).ToList();
                return View(listaEncargado);
            }
            
        }
    }
}