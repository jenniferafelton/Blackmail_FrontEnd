#pragma checksum "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4498867ff30ade51e8b2888356b3db9cf7f64653"
// <auto-generated/>
#pragma warning disable 1591
namespace Blackmail.Client.Shared
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
#line 3 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
using Blackmail.Models.BlackmailDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
using Blackmail.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : Blackmail.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(8);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row justify-content-start align-items-center");
                __builder2.AddMarkupContent(13, "\n      ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-6 d-flex align-items-center");
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(17);
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 18 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(20);
                __builder2.AddAttribute(21, "Text", "Blackmail");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(26);
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(29);
                __builder2.AddAttribute(30, "Name", "main");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(32, "\n    ");
                    __builder3.AddContent(33, 
#nullable restore
#line 29 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(34, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(36, (__value) => {
#nullable restore
#line 26 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(38);
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(40, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(41);
                __builder2.AddAttribute(42, "style", "height: 100%");
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(44, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(45);
                    __builder3.AddAttribute(46, "Text", "Home");
                    __builder3.AddAttribute(47, "Path", "home");
                    __builder3.AddAttribute(48, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
                                                               Security.IsInRole(new string[]{"Authenticated", "Everybody"})

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(50);
                    __builder3.AddAttribute(51, "Text", "All Blackmail");
                    __builder3.AddAttribute(52, "Path", "all-blackmail");
                    __builder3.AddAttribute(53, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
                                                                                 Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(55);
                    __builder3.AddAttribute(56, "Text", "Submit Blackmail");
                    __builder3.AddAttribute(57, "Path", "submit-blackmail");
                    __builder3.AddAttribute(58, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
                                                                                       Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(60);
                    __builder3.AddAttribute(61, "Text", "Login");
                    __builder3.AddAttribute(62, "Path", "login");
                    __builder3.AddAttribute(63, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
                                                                 Security.IsInRole(new string[]{"Everybody"})

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(66, (__value) => {
#nullable restore
#line 33 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(68);
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(71);
                __builder2.AddAttribute(72, "Text", "Blackmail, Copyright Ⓒ 2020");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<MainLayout> L { get; set; }
    }
}
#pragma warning restore 1591
