using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ORDEN_COMPRA.Models;
namespace ORDEN_COMPRA.Controllers
{
    public class ArticuloController : Controller
    {
        // GET: Articulo
        public ActionResult Index()
        {
            using(var bd =new OCEntities())
            {
                List<ArticuloCLS> listaArticulo = null;
                listaArticulo = (from articulo in bd.ARTICULO
                                 join proveedor in bd.PROVEEDOR
                                 on articulo.RUC_proveedor equals proveedor.RUC_proveedor
                                 select new ArticuloCLS
                                 {
                                     codigoarticulo = articulo.codigo_A,
                                     rucproveedor = proveedor.RUC_proveedor,
                                     nombrearticulo = articulo.nombre_articulo,
                                     precio = articulo.precio,
                                     stock = articulo.stock,
                                     unidad = articulo.unidad
                                 }).ToList();
                return View(listaArticulo);
            }
        }
    }
}