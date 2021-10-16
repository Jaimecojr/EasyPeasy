using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Peliculas.Shared.Entity
{
    public class Actor
    {
        public int Id {get;set;}
        [Required]
        public string ActorName {get;set;}
        [Required]
        public Gender Gender {get;set;}
        [Required]
        public DateTime BirthDate {get;set;}
        [Required]
        public string Bio {get;set;}
        [Required]
        public string ActorImg {get;set;}
        /* Campo que no se va almacenar en ningun tabla de la bd */
        [NotMapped]
        public string Character{get;set;}
        public List<MovieActors> MoviesActor {get;set;}
    }

    public enum Gender
    {
        Femenino = 0,
        Masculino = 1
    }
}