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
            using(var bd  = new OCEntities())
            {
                List<DatosCompraCLS> listaOrdenCompra = null;
                listaOrdenCompra = (from datoscompra in bd.DATOS_COMPRA
                                    join encargado in bd.ENCARGADO
                                    on datoscompra.RUC_cliente equals encargado.RUC_cliente
                                    join proveedor in bd.PROVEEDOR
                                    on datoscompra.RUC_proveedor equals proveedor.RUC_proveedor
                                    join moneda in bd.PAGO
                                    on datoscompra.moneda equals moneda.moneda
                                    select new DatosCompraCLS
                                    {
                                        nroordencompra = datoscompra.nro_orden_compra,
                                        ruccliente = datoscompra.RUC_cliente,
                                        rucproveedor = datoscompra.RUC_proveedor,
                                        moneda = datoscompra.moneda,
                                        solicitante = datoscompra.solicitante,
                                        obra = datoscompra.obra,
                                        ordentaller = datoscompra.orden_de_taller,
                                        representante = datoscompra.representante,
                                        prioridad_compra = datoscompra.prioridad_compra,
                                        autorizante = datoscompra.autorizante,
                                        requerimiento = datoscompra.requerimiento,
                                        metodopago = datoscompra.metodo_de_pago,
                                        observaciones = datoscompra.observaciones,
                                        Fecha = datoscompra.fecha,
                                        Subtotal = datoscompra.SubtoTal_T,
                                        Total = datoscompra.Total
                                    }
                                    ).ToList();
                return View(listaOrdenCompra);
            }
            
        }
    }
}