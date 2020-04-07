using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace FinalProg.Models
{
    public class Context:DbContext
    {
        
        public Context()
            : base ("name-context")

        {

        }
        public virtual DbSet<Categorias> Categorias { get; set; }
    }
}

