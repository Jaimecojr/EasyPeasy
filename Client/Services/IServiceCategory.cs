using Peliculas.Shared.Entity;
using System.Collections.Generic;
namespace Peliculas.Client.Services
{
    public interface IServiceCategory
    {
         List<Category> GetCategories();
         void AddCategorie(Category nuevaCategory);
    }
}