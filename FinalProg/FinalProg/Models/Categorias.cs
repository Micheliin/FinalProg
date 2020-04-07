using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalProg.Models
{
    [Table("Categorias")]
    public class Categorias
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdCategoria { get; set; }

        [Required]
        public string Categoria { get; set; }

    }
}