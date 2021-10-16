using System.Security.AccessControl;
using Peliculas.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Peliculas.Client.Services
{
    public interface IServiceMovie
    {
        List<Movie> PeliculasGuardadas {get;set;}
        List<Movie> GetMovies();
        Task<HttpResponseWrapper<object>> Post<T>(string url, T send);
        Task<HttpResponseWrapper<TResponse>> Post<T,TResponse>(string url, T send);
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        void DeleteMovie(int a);
        void AddMovie(Movie m);
    }
}