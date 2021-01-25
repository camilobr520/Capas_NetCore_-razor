using PruebaCamiloBautista.Dominio.Modelos;
using PruebaCamiloBautista.Dominio.Modelos.Respuesta;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PruebaCamiloBautista.Dominio.Modelos.Request;

namespace PruebaCamiloBautista.Dominio.Service
{
   public class EditorialService:IEditorialService
    {
        public Respuesta GetEditoriales()
        {
            using (ViajemosContext db = new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                try
                {

                    var lst = db.Editoriales.OrderByDescending(d => d.Id).ToList();
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

        public Respuesta AddEditoriales(EditorialRequest model)
        {
            using (ViajemosContext db = new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                oRespuesta.Success = 0;
                try
                {
                    var editorial = new Editoriale();
                    editorial.Nombre = model.Nombre;
                    editorial.Sede = model.Sede;
                    db.Editoriales.Add(editorial);
                    db.SaveChanges();
                    oRespuesta.Success = 1;

                }
                catch (Exception ex)
                {
                    oRespuesta.Message = ex.Message;
                }

                return oRespuesta;
            }

        }
        public Respuesta EditEditoriales(EditorialRequest model)
        {
            using (ViajemosContext db = new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                oRespuesta.Success = 0;
                try
                {
                    Editoriale oeditorial = db.Editoriales.Find(model.Id);
                    oeditorial.Nombre = model.Nombre;
                    oeditorial.Sede = model.Sede;
                    db.Entry(oeditorial).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Success = 1;

                }
                catch (Exception ex)
                {
                    oRespuesta.Message = ex.Message;
                }

                return oRespuesta;
            }

        }
        public Respuesta DeleteEditoriales(EditorialRequest model)
        {
            using (ViajemosContext db = new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                oRespuesta.Success = 0;
                try
                {
                    Editoriale oeditorial = db.Editoriales.Find(model.Id);
                    db.Remove(oeditorial);
                    db.SaveChanges();
                    oRespuesta.Success = 1;

                }
                catch (Exception ex)
                {
                    oRespuesta.Message = ex.Message;
                }

                return oRespuesta;
            }

        }

    }
}
