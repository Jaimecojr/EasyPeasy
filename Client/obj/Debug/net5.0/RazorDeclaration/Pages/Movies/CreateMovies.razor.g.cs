// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace peliculas.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\peliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\peliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\peliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\peliculas\Client\_Imports.razor"
using peliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\peliculas\Client\_Imports.razor"
using peliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\peliculas\Client\_Imports.razor"
using Peliculas.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\peliculas\Client\_Imports.razor"
using Peliculas.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\peliculas\Client\Pages\Movies\CreateMovies.razor"
using peliculas.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/create")]
    public partial class CreateMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "c:\peliculas\Client\Pages\Movies\CreateMovies.razor"
       
    private Movie Movie = new Movie();
    private List<Category> CategoriasNoSeleccionadas = new List<Category>();
    protected override void OnInitialized()
    {
        CategoriasNoSeleccionadas = new List<Category>(){
            new Category(){Id = 1, NameCategory="Comedia"},
            new Category(){Id = 2, NameCategory="Terror"},
            new Category(){Id = 3, NameCategory="Ciencia Ficcion"},
            new Category(){Id = 4, NameCategory="Drama"}      
            };
    }
    private async Task Create()
    {
        var httpResponse = await repositorio.Post("api/movies", Movie);
        if (httpResponse.Error)
        {
            await showMessage.ShowErrorMessage(await httpResponse.GetBody());
        }
        else
        {
            navigationManager.NavigateTo("/");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie repositorio { get; set; }
    }
}
#pragma warning restore 1591
