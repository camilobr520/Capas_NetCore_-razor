using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCamiloBautista.Presentacion.Models;
using PruebaCamiloBautista.Dominio.Service;
using PruebaCamiloBautista.Dominio.Modelos.Request;
using PruebaCamiloBautista.Dominio.Modelos.Respuesta;
using PruebaCamiloBautista.Dominio.Modelos;

namespace PruebaCamiloBautista.Presentacion.Controllers
{
    public class MaestroDetalleController : Controller
    {
        private IAutoresService _autores;
        private ILibrosService _libros;
        private IEditorialService _editorial;
        public MaestroDetalleController(IAutoresService autores, ILibrosService libros, IEditorialService editorial)
        {
            this._autores = autores;
            this._libros = libros;
            this._editorial = editorial;
        }

        // GET: MaestroDetalleController
        public ActionResult Index()
        {
            var lst = _editorial.GetEditoriales().Data;
            ViewBag.listofItems = lst;

            var libros = _libros.GetLibros().Data;
            ViewBag.listLibros = libros;
            return View();
        }

        [HttpPost]
        public ActionResult Add(LibrosRequest model)
        {
            try
            {
                _libros.AddLibros(model);
                ViewBag.Message = "Registro Insertado";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
           
        }

        
    

        public ActionResult Delete(int id)
        {
            LibrosRequest olibro = new LibrosRequest();
            try
            {
                olibro.Id = id;
                _libros.DeleteLibros(olibro);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        // GET: MaestroDetalleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MaestroDetalleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MaestroDetalleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id,string titulo,string sinopsis,string npaginas,long isbn, int editorialesid)
        {
            var lst = _editorial.GetEditoriales().Data;
            ViewBag.listofItems = lst;
            ViewBag.id = id;
            ViewBag.titulo = titulo;
            ViewBag.sinopsis = sinopsis;
            ViewBag.npaginas = npaginas;
            ViewBag.isbn = isbn;
            ViewBag.editorialesid = editorialesid;
            return View();
        }

        public ActionResult EditSave(LibrosRequest model)
        {
            try
            {
                _libros.EditLibros(model);
                ViewBag.Message = "Registro Modificado";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        

        // GET: MaestroDetalleController/Delete/5


        // POST: MaestroDetalleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
