using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialProgra.Models
{
    public class Modelosuerte
    {
        [Key]
        public int SuerteId { get; set; }
        public string Detalle { get; set; }
        [Url]
        public string Imagen { get; set; }
    }
}
