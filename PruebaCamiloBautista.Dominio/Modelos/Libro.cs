using System;
using System.Collections.Generic;

#nullable disable

namespace PruebaCamiloBautista.Dominio.Modelos
{
    public partial class Libro
    {
        public long Isbn { get; set; }
        public int EditorialesId { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string NPaginas { get; set; }
        public int Id { get; set; }

        public virtual Editoriale Editoriales { get; set; }
    }
}
