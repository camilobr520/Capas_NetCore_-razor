using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PruebaCamiloBautista.Dominio.Modelos.Request
{
  public class LibrosRequest
    {
        [Required]
        public long ISBN { set; get; }
        [Required]
        public int Editoriales_id  { set; get; }
        [Required]
        public string Titulo { set; get; }
        [Required]
        public string Sinopsis { set; get; }
        [Required]
        public string N_paginas { set; get; }

        public int Id { set; get; }


    }
}
