using PruebaCamiloBautista.Dominio.Modelos;
using PruebaCamiloBautista.Dominio.Modelos.Respuesta;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using PruebaCamiloBautista.Dominio.Modelos.Request;

namespace PruebaCamiloBautista.Dominio.Service
{
   public class LibrosService:ILibrosService
    {
      
        public Respuesta GetLibros()
        {
            using (ViajemosContext db = new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                try
                {

                    //  var lst = db.Libros.OrderByDescending(d => d.Id).ToList();


                    List<Libro> lst = (from d in db.Libros
                                                       
                                                       select new Libro
                                                       {
                                                           Titulo = d.Titulo,
                                                           Sinopsis = d.Sinopsis,
                                                           NPaginas=d.NPaginas,
                                                           Id=d.Id,
                                                           Isbn=d.Isbn,
                                                           Editoriales=d.Editoriales,
                                                           EditorialesId=d.EditorialesId
                                                       }).ToList();


                    oRespuesta.Success = 1;
                    oRespuesta.Data = lst;
                }
                catch (Exception ex)
                {
                    oRespuesta.Message = ex.Message;
                }

                return oRespuesta;
            }
        }
        public Respuesta AddLibros(LibrosRequest model)
        {
            using (ViajemosContext db = new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                oRespuesta.Success = 0;
                try
                {
                    var libro = new Libro();
                    libro.Isbn = model.ISBN;
                    libro.NPaginas = model.N_paginas;
                    libro.Titulo = model.Titulo;
                    libro.Sinopsis = model.Sinopsis;
                    libro.EditorialesId = model.Editoriales_id;
                    db.Libros.Add(libro);
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

        public Respuesta EditLibros(LibrosRequest model)
        {
            using (ViajemosContext db = new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                oRespuesta.Success = 0;
                try
                {
                    Libro oLibro = db.Libros.Find(model.Id); 
                    oLibro.Isbn = model.ISBN;
                    oLibro.NPaginas = model.N_paginas;
                    oLibro.Titulo = model.Titulo;
                    oLibro.Sinopsis = model.Sinopsis;
                    oLibro.EditorialesId = model.Editoriales_id;
                    db.Entry(oLibro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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

        public Respuesta DeleteLibros(LibrosRequest model)
        {
            using (ViajemosContext db = new ViajemosContext())
            {
                Respuesta oRespuesta = new Respuesta();
                oRespuesta.Success = 0;
                try
                {
                    Libro oLibro = db.Libros.Find(model.Id);
                    db.Remove(oLibro);
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
