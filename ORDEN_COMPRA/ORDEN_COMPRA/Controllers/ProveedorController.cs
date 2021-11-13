using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ORDEN_COMPRA.Models;
namespace ORDEN_COMPRA.Controllers
{
    public class ProveedorController : Controller
    {
        // GET: Proveedor
        public ActionResult Index()
        {
            using (var bd = new OrdenCompraEntities())
            {
                List<ProveedorCLS> listaProveedor = null;
                listaProveedor = (from proveedor in bd.PROVEEDOR
                                  select new ProveedorCLS
                                  {
                                      rucproveedor = proveedor.RUC_proveedor,
                                      nombreempresa = proveedor.nombre_empresa,
                                      ciudad = proveedor.ciudad,
                                      distrito = proveedor.distrito,
                                      calle = proveedor.distrito,
                                      numero = proveedor.numero,
                                  }).ToList();

                return View(listaProveedor);
            }
        }
    }
}