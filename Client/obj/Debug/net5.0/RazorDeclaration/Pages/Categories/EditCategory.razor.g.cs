// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace peliculas.Client.Pages.Categories
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
#line 2 "c:\peliculas\Client\Pages\Categories\EditCategory.razor"
using peliculas.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/edit/{Id:int}")]
    public partial class EditCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "c:\peliculas\Client\Pages\Categories\EditCategory.razor"
       
    [Parameter] public int Id {get;set;}
    private Category Category;

    protected override void OnInitialized(){
        Category = new Category(){
            Id = Id,
            NameCategory= "Comedia"
        };
    }

    private void Edit(){
        Console.WriteLine($"Id: {Category.Id}");
        Console.WriteLine($"Id: {Category.NameCategory}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
