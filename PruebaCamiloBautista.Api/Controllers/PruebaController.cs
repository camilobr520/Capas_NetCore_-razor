using Microsoft.AspNetCore.Mvc;
using PruebaCamiloBautista.Dominio.Modelos.Request;
using PruebaCamiloBautista.Dominio.Modelos.Respuesta;
using PruebaCamiloBautista.Dominio.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCamiloBautista.Api.Controllers
{
    
    [ApiController]
    public class PruebaController : Controller
    {
          private IAutoresService _autores;
          private ILibrosService _libros;
          private IEditorialService _editorial;


        public PruebaController(IAutoresService autores, ILibrosService libros, IEditorialService editorial)
        {
            this._autores = autores;
            this._libros = libros;
            this._editorial = editorial;
        }

        [HttpGet]
        [Route("api/autores")]
        public IActionResult GetAutores()
        {
            return Ok(_autores.GetAutores());

        }
        [HttpGet]
        [Route("api/libros")]
        public IActionResult GetLibros()
        {
            return Ok(_libros.GetLibros());

        }

        [HttpPost]
        [Route("api/addlibros")]
        public IActionResult AddLibros([FromBody]LibrosRequest model)
        {
            return Ok(_libros.AddLibros(model));

        }

        [HttpPost]
        [Route("api/editlibros")]
        public IActionResult EditLibros([FromBody] LibrosRequest model)
        {
            return Ok(_libros.EditLibros(model));

        }

        [HttpPost]
        [Route("api/deletelibros")]
        public IActionResult DeleteLibros([FromBody] LibrosRequest model)
        {
            return Ok(_libros.DeleteLibros(model));

        }

        [HttpGet]
        [Route("api/editoriales")]
        public IActionResult GetEditoriales()
        {
            return Ok(_editorial.GetEditoriales());

        }

        [HttpPost]
        [Route("api/addeditoriales")]
        public IActionResult AddEditoriales([FromBody] EditorialRequest model)
        {
            return Ok(_editorial.AddEditoriales(model));

        }

        [HttpPost]
        [Route("api/editeditoriales")]
        public IActionResult EditEditoriales([FromBody] EditorialRequest model)
        {
            return Ok(_editorial.EditEditoriales(model));

        }

        [HttpPost]
        [Route("api/deleteeditoriales")]
        public IActionResult DeleteEditoriales([FromBody] EditorialRequest model)
        {
            return Ok(_editorial.DeleteEditoriales(model));

        }
    }
}

