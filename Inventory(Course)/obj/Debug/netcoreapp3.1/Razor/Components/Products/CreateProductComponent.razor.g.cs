#pragma checksum "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10b5c51f3d436b677f3f9075dbbe66672139a2ea"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory_Course_.Components.Products
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
#line 1 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                     oProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<label>Referencia:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                                    oProduct.ProductId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.ProductId = __value, oProduct.ProductId))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.ProductId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<label>Nombre del Producto:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                                    oProduct.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.ProductName = __value, oProduct.ProductName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.ProductName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.AddMarkupContent(31, "<label>Descripcion:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                                    oProduct.ProductDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.ProductDescription = __value, oProduct.ProductDescription))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.ProductDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.AddMarkupContent(42, "<label>Categoria:</label>\r\n            ");
                __Blazor.Inventory_Course_.Components.Products.CreateProductComponent.TypeInference.CreateInputSelect_0(__builder2, 43, 44, "form-control", 45, 
#nullable restore
#line 20 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                                      oProduct.CategoryId

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.CategoryId = __value, oProduct.CategoryId)), 47, () => oProduct.CategoryId, 48, (__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n");
#nullable restore
#line 21 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                 foreach (var category in categories)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(50, "                    ");
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", 
#nullable restore
#line 23 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                                    category.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(53, 
#nullable restore
#line 23 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                                                          category.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n");
#nullable restore
#line 24 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(55, "            ");
                }
                );
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n        ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "type", "button");
                __builder2.AddAttribute(60, "class", "btn-success");
                __builder2.AddAttribute(61, "value", "Agregar Producto");
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
                                                                                    SaveProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\Products\CreateProductComponent.razor"
       
    ProductEntity oProduct = new ProductEntity();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    private void SaveProduct()
    {
        B_Product.CreateProduct(oProduct);
    }

    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.CategoryList();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Inventory_Course_.Components.Products.CreateProductComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
