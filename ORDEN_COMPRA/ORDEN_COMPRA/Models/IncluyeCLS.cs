using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORDEN_COMPRA.Models
{
    public class IncluyeCLS
    {
        public string nroordencompra { get; set; }
        public string codigoarticulo { get; set; }
        public int cantidad { get; set; }
        public float subtotal { get; set; }
    }
}