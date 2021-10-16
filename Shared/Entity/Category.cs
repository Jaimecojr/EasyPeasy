using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Shared.Entity
{
    public class Category
    {
        public int Id {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string NameCategory {get;set;}
        public List <CategoryMovie> CategoriesMovie {get;set;}
        
    }
}