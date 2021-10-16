using System;
using Peliculas.Shared.Entity;
using System.Collections.Generic;
namespace Peliculas.Client.Services
{
    public class ServiceCategory:IServiceCategory
    {
        public List<Category> CategoriasGuardadas = new List<Category>(){
            new Category(){Id=0,NameCategory="Drama"},
            new Category(){Id=1,NameCategory="Comedia"},
            new Category(){Id=2,NameCategory="Accion"},
            new Category(){Id=3,NameCategory="Aventuras"}
        };
        

        public void AddCategorie(Category nuevaCategory)
        {
            CategoriasGuardadas.Add(nuevaCategory);
        }

        public List<Category> GetCategories()
        {
            return CategoriasGuardadas;
        }

    }
}