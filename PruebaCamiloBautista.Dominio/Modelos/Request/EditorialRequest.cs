using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PruebaCamiloBautista.Dominio.Modelos.Request
{
   public class EditorialRequest
    {
        [Required]
        public int Id { set; get; }
        [Required]
        public string Nombre { set; get; }
        [Required]
        public string Sede { set; get; }
    }
}
