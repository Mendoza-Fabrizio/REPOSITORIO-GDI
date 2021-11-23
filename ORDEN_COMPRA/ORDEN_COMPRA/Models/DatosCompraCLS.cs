using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORDEN_COMPRA.Models
{
    public class DatosCompraCLS
    {
        public string nroordencompra { get; set; }
        public string ruccliente { get; set; }
        public string rucproveedor { get; set; }
        public string moneda { get; set; }
        public string solicitante { get; set; }
        public string obra { get; set; }
        public string ordentaller { get; set; }
        public string representante { get; set; }
        public string prioridad_compra { get; set; }
        public string autorizante { get; set; }
        public string requerimiento { get; set; }
        public string metodopago { get; set; }
        public string observaciones { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Total { get; set; }
    }
}