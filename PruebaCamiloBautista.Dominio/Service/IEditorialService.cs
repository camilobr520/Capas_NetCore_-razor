using PruebaCamiloBautista.Dominio.Modelos.Request;
using PruebaCamiloBautista.Dominio.Modelos.Respuesta;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaCamiloBautista.Dominio.Service
{
   public interface IEditorialService
    {
        public Respuesta GetEditoriales();
        public Respuesta AddEditoriales(EditorialRequest model);
        public Respuesta EditEditoriales(EditorialRequest model);
        public Respuesta DeleteEditoriales(EditorialRequest model);
    }
}
