using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaCamiloBautista.Dominio.Modelos.Respuesta
{
   public class Respuesta
    {
        public int Success { set; get; }
        public object Data { set; get; }
        public string Message { set; get; }

        public Respuesta()
        {
            // se inicializa en 0, solo se pasa a 1 cuando la consulta del api es exitoso
            this.Success = 0;
        }
    }
}
