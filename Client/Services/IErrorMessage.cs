using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peliculas.Client.Services
{
    public interface IErrorMessage
    {
        Task ShowErrorMessage(string message);
    }
}