#pragma checksum "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac9654a9ba5d8643482f159707527df953d7482a"
// <auto-generated/>
#pragma warning disable 1591
namespace Blackmail.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using Blackmail.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jenni\Documents\FrontEndWeb\client\_Imports.razor"
using Blackmail.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
using Blackmail.Models.BlackmailDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
using Blackmail.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/application-roles")]
    public partial class ApplicationRoles : Blackmail.Pages.ApplicationRolesComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Roles");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<IdentityRole>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<IdentityRole>>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                                                                     roles

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<IdentityRole>>(27);
                    __builder3.AddAttribute(28, "Property", "Name");
                    __builder3.AddAttribute(29, "Title", "Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<IdentityRole>>(31);
                    __builder3.AddAttribute(32, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                               false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "Width", "70px");
                    __builder3.AddAttribute(35, "Template", (Microsoft.AspNetCore.Components.RenderFragment<IdentityRole>)((identityRole) => (__builder4) => {
                        __builder4.AddMarkupContent(36, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(37);
                        __builder4.AddAttribute(38, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 29 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "Icon", "close");
                        __builder4.AddAttribute(40, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 29 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, identityRole)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(42, "onclick", 
#nullable restore
#line 29 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                                                                                                                                                                                            true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(43, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(45, (__value) => {
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\ApplicationRoles.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<IdentityRole>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<ApplicationRoles> L { get; set; }
    }
}
#pragma warning restore 1591
