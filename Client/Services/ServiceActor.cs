using Peliculas.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Peliculas.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List<Actor> GetActors(){
            return new List<Actor>{
                new Actor(){Id = 1, ActorName = "Katherine LaNasa", Gender = Gender.Femenino, BirthDate =  new DateTime(1966,12,01), Bio = "LaNasa nació en Nueva Orleans, Luisiana, hija de Anne (de soltera Hardin) y el Dr. James J. LaNasa, Jr., cirujano plástico. LaNasa comenzó a bailar a la edad de 12 años y, a la edad de 14, fue aceptada en la Escuela de Artes de Carolina del Norte en Winston-Salem, Carolina del Norte. Después de un aprendizaje con el Ballet de Milwaukee, LaNasa bailó con el Ballet West de Salt Lake City y el Ballet de Karole Armitage.", ActorImg = "/Images/img1.jpg"},
                new Actor(){Id = 2, ActorName = "Janaina Liesenfeld", Gender = Gender.Femenino, BirthDate =  new DateTime(1998,01,01), Bio = "Janaina Liesenfeld nació en 1998 en Berlín, Alemania. Ella es una actriz, conocida por Yung (2018)", ActorImg = "/Images/img2.jpg"},
                new Actor(){Id = 3, ActorName = "Ryan Reynolds", Gender = Gender.Masculino, BirthDate =  new DateTime(1976,10,23), Bio = "Ryan Rodney Reynolds (nacido el 23 de octubre de 1976) es un actor, productor de cine y empresario canadiense-estadounidense. Comenzó su carrera protagonizando la telenovela canadiense para adolescentes Hillside (1991-1993) y tuvo papeles menores antes de conseguir el papel principal en la comedia Two Guys and a Girl entre 1998 y 2001.", ActorImg = "/Images/img3.jpg"},
                new Actor(){Id = 4, ActorName = "Oh Yeong-su", Gender = Gender.Masculino, BirthDate =  new DateTime(1944,10,19), Bio = "No tenemos una biografía de Oh Yeong-su.", ActorImg = "/Images/img4.jpg"},
                new Actor(){Id = 5, ActorName = "Scarlett Johansson", Gender = Gender.Femenino, BirthDate =  new DateTime(1984,11,22), Bio = "Scarlett Johansson, es una actriz, modelo y cantante estadounidense. Hizo su debut cinematográfico en North (1994) y más tarde fue nominada para el premio Independent Spirit a la mejor protagonista femenina por su actuación en Manny & Lo (1996), obteniendo más aclamación y prominencia con papeles en The Horse Whisperer (1998) y Ghost. Mundo (2001). Pasó a papeles adultos con sus actuaciones en Girl with a Pearl Earring (2003) y Lost in Translation (2003) de Sofia Coppola, por la que ganó un premio BAFTA a la Mejor Actriz en un Papel Protagónico; ambas películas también le valieron nominaciones al Globo de Oro.", ActorImg = "/Images/img5.jpg"}
            };
        }
    }
}