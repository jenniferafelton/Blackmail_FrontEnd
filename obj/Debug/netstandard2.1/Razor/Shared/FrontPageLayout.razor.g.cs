#pragma checksum "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\FrontPageLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcc1d4cd373f3880b2afd540dd57d6f245c3cf03"
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
#line 3 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\FrontPageLayout.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\FrontPageLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\FrontPageLayout.razor"
using Blackmail.Models.BlackmailDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\FrontPageLayout.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\FrontPageLayout.razor"
using Blackmail.Models;

#line default
#line hidden
#nullable disable
    public partial class FrontPageLayout : Blackmail.Layouts.FrontPageLayoutComponent
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
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(8);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(11);
                __builder2.AddAttribute(12, "style", "display: flex");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeader>(14);
                __builder2.AddAttribute(15, "style", "height: 121px; text-align: left; width: 1134px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenBody>(17);
                __builder2.AddAttribute(18, "style", "height: 641px; vertical-align: middle");
                __builder2.AddComponentReferenceCapture(19, (__value) => {
#nullable restore
#line 20 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\FrontPageLayout.razor"
                      body1 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(21, (__value) => {
#nullable restore
#line 14 "C:\Users\jenni\Documents\FrontEndWeb\client\Shared\FrontPageLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<FrontPageLayout> L { get; set; }
    }
}
#pragma warning restore 1591
