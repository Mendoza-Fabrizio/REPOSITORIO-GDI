using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ORDEN_COMPRA.Models
{
    public class ArticuloCLS
    {
        [Display(Name ="Codigo")]
        public string codigoarticulo{get;set; }
        [Display(Name = "Nombre Articulo")]
        public string nombrearticulo { get; set; }
        [Display(Name = "Precio")]
        public float precio { get; set; }
        [Display(Name = "Stock")]
        public int stock { get; set; }
        [Display(Name = "Unidad")]
        public string unidad { get; set; }
        [Display(Name = "RUC Proveedor")]
        public string rucproveedor { get; set; }
    }
}