#pragma checksum "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07d88428a659ad3a56474ab72114f146226f0184"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory_Course_.Components.InOuts
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
#nullable restore
#line 1 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateInOutComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "class", " form-control");
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                                             OnChangeWarehouse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", true);
            __builder.AddContent(9, "Seleccione una bodega ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 7 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
         foreach (var warehouse in warehouses)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 9 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                            warehouse.WarehouseId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, 
#nullable restore
#line 9 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                                                    warehouse.WarehouseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 10 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<hr>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                 oInOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __Blazor.Inventory_Course_.Components.InOuts.CreateInOutComponent.TypeInference.CreateInputSelect_0(__builder2, 26, 27, " form-control", 28, 
#nullable restore
#line 16 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                                                        oInOut.StorageId

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oInOut.StorageId = __value, oInOut.StorageId)), 30, () => oInOut.StorageId, 31, (__builder3) => {
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.AddMarkupContent(33, "<option value>Seleccione un producto ...</option>\r\n");
#nullable restore
#line 18 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
             foreach (var storage in storages)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(34, "                ");
                    __builder3.OpenElement(35, "option");
                    __builder3.AddAttribute(36, "value", 
#nullable restore
#line 20 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                                storage.StorageId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(37, 
#nullable restore
#line 20 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                                                    storage.Product.ProductName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n");
#nullable restore
#line 21 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(39, "        ");
                }
                );
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.AddMarkupContent(45, "<label>Escriba la cantidad</label>\r\n        ");
                __Blazor.Inventory_Course_.Components.InOuts.CreateInOutComponent.TypeInference.CreateInputNumber_1(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 26 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                                                       oInOut.Quantity

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oInOut.Quantity = __value, oInOut.Quantity)), 50, () => oInOut.Quantity);
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.AddMarkupContent(56, "<label>Es una entrada?</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(57);
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                                                         oInOut.IsInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oInOut.IsInput = __value, oInOut.IsInput))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => oInOut.IsInput));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n    ");
                __builder2.OpenElement(64, "input");
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "type", "button");
                __builder2.AddAttribute(67, "value", 
#nullable restore
#line 33 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                                                      buttonValue

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
                                                                             SaveInOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Brandon\Documents\Cursos\Projects\Curso de Desarrollo Web con Blazor y dotNet\Inventory(Course)\Inventory(Course)\Components\InOuts\CreateInOutComponent.razor"
       
    InOutEntity oInOut = new InOutEntity();
    List<WarehouseEntity> warehouses = new List<WarehouseEntity>();
    List<StorageEntity> storages = new List<StorageEntity>();

    string buttonValue => oInOut.IsInput ? "Registrar Entrada" : "Registrar Salida";

    protected override async Task OnInitializedAsync()
    {
        warehouses = B_Warehouse.WarehousesList();
    }

    private void OnChangeWarehouse(ChangeEventArgs e)
    {
        var idWareHouse = e.Value.ToString();

        storages = B_Storage.StoragesProductsByWarehouse(idWareHouse);
    }

    private void SaveInOut()
    {
        
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Inventory_Course_.Components.InOuts.CreateInOutComponent
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
