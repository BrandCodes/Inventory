#pragma checksum "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Pages\Products\ListProductPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15c0b219b925b3819b1fa9a77445735c8de0c303"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory_Course_.Pages.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Inventory_Course_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Inventory_Course_.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Inventory_Course_.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Inventory_Course_.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Inventory_Course_.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Inventory_Course_.Components.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\_Imports.razor"
using Inventory_Course_.Components.InOuts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/list")]
    public partial class ListProductPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"product/create\">Crear Producto</a>\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Inventory_Course_.Components.Products.ListProductsComponent>(2);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
