#pragma checksum "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "287c8085d1535349c13dc7e9412206afd6fe8b30"
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
#line 5 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
using Blackmail.Models.BlackmailDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
using Blackmail.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-application-role")]
    public partial class AddApplicationRole : Blackmail.Pages.AddApplicationRoleComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<IdentityRole>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<IdentityRole>(
#nullable restore
#line 19 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
                                                        role

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
                                                                         role != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IdentityRole>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IdentityRole>(this, 
#nullable restore
#line 19 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
                                                                                                 Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Component", "Name");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(34, "Name", "Name");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
                                                                                  role.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => role.Name = __value, role.Name))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => role.Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "Name");
                    __builder3.AddAttribute(41, "style", "position: absolute");
                    __builder3.AddAttribute(42, "Text", "Name is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "row");
                    __builder3.AddMarkupContent(48, "\n              ");
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(51, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(52);
                    __builder3.AddAttribute(53, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 35 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 35 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "Icon", "save");
                    __builder3.AddAttribute(56, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(58);
                    __builder3.AddAttribute(59, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 37 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "Text", "Cancel");
                    __builder3.AddAttribute(61, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AddApplicationRole.razor"
                                                                                    Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AddApplicationRole> L { get; set; }
    }
}
#pragma warning restore 1591
