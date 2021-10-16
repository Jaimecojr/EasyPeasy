using Peliculas.Shared.Entity;
using System.Collections.Generic;

namespace Peliculas.Client.Services
{
    public interface IServiceActor
    {
        List<Actor> GetActors();
    }
}


