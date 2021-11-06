using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ORDEN_COMPRA.Models
{
    public class EncargadoCLS
    {
        [Display(Name = "RUC")]
        public string ruccliente { get; set; }
        [Required]
        [Display(Name = "Nombre Empresa")]
        public string nombreempresa { get; set; }
        [Display(Name = "Padron")]
        public string padron { get; set; }
    }
}