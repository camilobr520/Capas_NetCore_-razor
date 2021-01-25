using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCamiloBautista.Presentacion.Models
{
    public class Editoriales
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sede { get; set; }
        public virtual ICollection<Libros> Libros { get; set; }


    }
}
