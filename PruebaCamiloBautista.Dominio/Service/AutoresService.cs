using PruebaCamiloBautista.Dominio.Modelos;
using PruebaCamiloBautista.Dominio.Modelos.Respuesta;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCamiloBautista.Dominio.Service
{
   public class AutoresService:IAutoresService
    {
        public Object GetAutores()
        {
            using (ViajemosContext db=new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                try
                {

                    var lst = db.Autores.OrderByDescending(d => d.Id).ToList();
                    oRespuesta.Success = 1;
                    oRespuesta.Data = lst;
                }
                catch (Exception ex)
                {
                    oRespuesta.Message = ex.Message;
                }

                //ese metodo Ok convierte la lista a json
                return oRespuesta;
            }
        }
        public Object GetAutoresEditorial()
        {
            using (ViajemosContext db = new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                try
                {

                    var lst = db.Autores.OrderByDescending(d => d.Id).ToList();
                    oRespuesta.Success = 1;
                    oRespuesta.Data = lst;
                }
                catch (Exception ex)
                {
                    oRespuesta.Message = ex.Message;
                }

                //ese metodo Ok convierte la lista a json
                return oRespuesta;
            }
        }
    }
}
