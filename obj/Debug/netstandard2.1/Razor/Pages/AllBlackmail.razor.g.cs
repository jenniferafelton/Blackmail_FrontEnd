#pragma checksum "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eab2fbb8372fd71f550184f984b3623f99ccb40"
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
#line 5 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
using Blackmail.Models.BlackmailDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
using Blackmail.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/all-blackmail")]
    public partial class AllBlackmail : Blackmail.Pages.AllBlackmailComponent
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
                __builder2.AddAttribute(6, "Text", "Datum");
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
#line 21 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(20);
                __builder2.AddAttribute(21, "Placeholder", "Search ...");
                __builder2.AddAttribute(22, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(23, "Name", "Textbox0");
                __builder2.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await grid0.Reload();}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Blackmail.Models.BlackmailDb.Datum>>(26);
                __builder2.AddAttribute(27, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 25 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Blackmail.Models.BlackmailDb.Datum>>(
#nullable restore
#line 25 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                                                      getDataResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                                                                             getDataCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 25 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                                                                                                                                                 Grid0LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(34, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blackmail.Models.BlackmailDb.Datum>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blackmail.Models.BlackmailDb.Datum>(this, 
#nullable restore
#line 25 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                                                                                                                                                                            Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(35, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.BlackmailDb.Datum>>(37);
                    __builder3.AddAttribute(38, "Property", "Poster");
                    __builder3.AddAttribute(39, "Title", "Poster");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.BlackmailDb.Datum>>(41);
                    __builder3.AddAttribute(42, "Property", "person_being_bmed");
                    __builder3.AddAttribute(43, "Title", "Person Being Bmed");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.BlackmailDb.Datum>>(45);
                    __builder3.AddAttribute(46, "Property", "cost_of_removal");
                    __builder3.AddAttribute(47, "Title", "Cost Of Removal");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.BlackmailDb.Datum>>(49);
                    __builder3.AddAttribute(50, "Property", "image_path");
                    __builder3.AddAttribute(51, "Title", "Image Path");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.BlackmailDb.Datum>>(53);
                    __builder3.AddAttribute(54, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                      false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "Width", "70px");
                    __builder3.AddAttribute(57, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 35 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                                                     TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Blackmail.Models.BlackmailDb.Datum>)((blackmailModelsBlackmailDbDatum) => (__builder4) => {
                        __builder4.AddMarkupContent(59, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(60);
                        __builder4.AddAttribute(61, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 37 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(62, "Icon", "close");
                        __builder4.AddAttribute(63, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 37 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, blackmailModelsBlackmailDbDatum)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(65, "onclick", 
#nullable restore
#line 37 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                                                                                                                                                                                                               true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(68, (__value) => {
#nullable restore
#line 25 "C:\Users\jenni\Documents\FrontEndWeb\client\Pages\AllBlackmail.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Blackmail.Models.BlackmailDb.Datum>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AllBlackmail> L { get; set; }
    }
}
#pragma warning restore 1591