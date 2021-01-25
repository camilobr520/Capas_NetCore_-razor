using PruebaCamiloBautista.Dominio.Modelos.Request;
using PruebaCamiloBautista.Dominio.Modelos.Respuesta;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaCamiloBautista.Dominio.Service
{
   public interface ILibrosService
    {
        public Respuesta GetLibros();
        public Respuesta AddLibros(LibrosRequest model);
        public Respuesta EditLibros(LibrosRequest model);
        public Respuesta DeleteLibros(LibrosRequest model);
    }
}
