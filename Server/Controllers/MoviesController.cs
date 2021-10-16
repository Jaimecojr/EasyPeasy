using System.Threading;
using Peliculas.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Peliculas.Server.Storage;
using peliculas.Client.Pages.Movies;

namespace Peliculas.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorageClass FilesStorage;
        private readonly string carpeta = "movies";

        public MoviesController(ApplicationDbContext context,IFilesStorageClass filesStorage){
            this.context = context;
            this.FilesStorage = filesStorage;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie){
            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var movie_poster = Convert.FromBase64String(movie.Poster);
                movie.Poster = await FilesStorage.SaveFile(movie_poster,".jpg", carpeta);
            }
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }
        
        // [HttpGet]
        // public async Task<ActionResult<FilterMovies>> Get(){
        //     var limit = 10;
        //     var peliculasEnCartelera1 = await context.Movies.Where(x=>x.EnCartelera).Take(limit).OrderByDescending(x=>x.Premier).ToListAsync();
        //     var currentDate = DateTime.Today;
        //     var proximosEstrenos1 = await context.Movies.Where(x=>x.Premier > currentDate).OrderBy(x=>x.Premier).Take(limit).ToListAsync();
        //     var response = new FilterMovies (){
        //         PeliculasEnCartelera = peliculasEnCartelera1,
        //         ProximosEstrenos = proximosEstrenos1
        //     };
        //     return response; 
        // } 
        /* Consultar por un registro determinado */
        [HttpGet("{id}")]
        public async Task<ActionResult>Get(int id){
            var movie = await context.Movies.Where(x=>x.Id == id).Include(x=>x.CategoriesMovie).ThenInclude(x=>x.Category).Include(x=>x.MoviesActor).ThenInclude(x=>x.Actor).FirstOrDefaultAsync();
            if (movie == null){ return NotFound(); }
            return NoContent();
        }

    }
}