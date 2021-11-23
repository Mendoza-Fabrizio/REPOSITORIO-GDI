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
            using (var bd = new OCEntities())
            {
                //List<ProveedorCLS> listaProveedor = bd.sp_ordenCompra_entre_fecha(System.DateTime.Parse("1901-01-01"),System.DateTime.Parse("2030-01-01"));
                /*listaProveedor = (from proveedor in bd.PROVEEDOR
                                  select new ProveedorCLS
                                  {
                                      rucproveedor = proveedor.RUC_proveedor,
                                      nombreempresa = proveedor.nombre_empresa,
                                      ciudad = proveedor.ciudad,
                                      distrito = proveedor.distrito,
                                      calle = proveedor.distrito,
                                      numero = proveedor.numero,
                                  }).ToList();

                return View(listaProveedor);*/
                return View(bd.sp_ordenCompra_entre_fecha(System.DateTime.Parse("1901-01-01"), System.DateTime.Parse("2030-01-01")));
            }
        }
        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(ProveedorCLS oproveedorCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(oproveedorCLS);
            }
            else
            {
                using (var bd = new OCEntities())
                {
                    PROVEEDOR oProveedor = new PROVEEDOR();
                    oProveedor.RUC_proveedor = oproveedorCLS.rucproveedor;
                    oProveedor.nombre_empresa = oproveedorCLS.nombreempresa;
                    oProveedor.padron = oproveedorCLS.padron;
                    oProveedor.ciudad = oproveedorCLS.ciudad;
                    oProveedor.distrito = oproveedorCLS.distrito;
                    oProveedor.calle = oproveedorCLS.calle;
                    oProveedor.numero = oproveedorCLS.numero;
                    bd.PROVEEDOR.Add(oProveedor);
                    bd.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}