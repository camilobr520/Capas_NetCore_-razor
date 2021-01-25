using PruebaCamiloBautista.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PruebaCamiloBautista.Presentacion.Models
{
    public class Libros
    {
        [Required(ErrorMessage = "*Requerido")]
        [Range(1111111, 999999999999, ErrorMessage = "Fuera del rango")]
        public long Isbn { get; set; }
        [Required(ErrorMessage = "*Requerido")]
        [Display(Name = "Editor")]
   
        public int Editoriales_Id { get; set; }
        [Required(ErrorMessage ="*Requerido")]
        [StringLength(45)]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "*Requerido")]
        [StringLength(50)]
        public string Sinopsis { get; set; }
        [Required(ErrorMessage = "*Requerido")]
        [StringLength(30)]
        // [Display(Name = "Numero de páginas")]
        public string N_paginas { get; set; }
        [Required(ErrorMessage = "*Requerido")]
        public int Id { get; set; }

        public virtual Editoriale Editoriales { get; set; }


    }
}
