using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ORDEN_COMPRA.Models
{
    public class ProveedorCLS
    {
        [Display(Name = "RUC")]
        public string rucproveedor { get; set; }
        [Display(Name = "Nombre")]
        public string nombreempresa { get; set; }
        [Display(Name = "Padron")]
        public string padron { get; set; }
        [Display(Name = "Ciudad")]
        public string ciudad { get; set; }
        [Display(Name = "Distrito")]
        public string distrito { get; set; }
        [Display(Name = "Calle")]
        public string calle { get; set; }
        [Display(Name = "Numero")]
        public string numero { get; set; }
    }
}