#pragma checksum "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef3abc770fa95bfb98e71e9b9e68e379d9cb4f1"
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
#line 1 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using Blackmail.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\_Imports.razor"
using Blackmail.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
using Blackmail.Models.AzureBlackmail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
using Blackmail.Models.Mssql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
using Blackmail.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/user-infos")]
    public partial class UserInfos : Blackmail.Pages.UserInfosComponent
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
                __builder2.AddAttribute(6, "Text", "User Infos");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(14);
                __builder2.AddAttribute(15, "Placeholder", "Search ...");
                __builder2.AddAttribute(16, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(17, "Name", "Textbox0");
                __builder2.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await grid0.Reload();}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Blackmail.Models.Mssql.UserInfo>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Blackmail.Models.Mssql.UserInfo>>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
                                                                                                                                      getUserInfosResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
                                                                                                                                                                  getUserInfosCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
                                                                                                                                                                                                                                        Grid0LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.Mssql.UserInfo>>(30);
                    __builder3.AddAttribute(31, "Property", "ID");
                    __builder3.AddAttribute(32, "Title", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.Mssql.UserInfo>>(34);
                    __builder3.AddAttribute(35, "Property", "BlackmailerName");
                    __builder3.AddAttribute(36, "Title", "Blackmailer Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.Mssql.UserInfo>>(38);
                    __builder3.AddAttribute(39, "Property", "BlackmaileeName");
                    __builder3.AddAttribute(40, "Title", "Blackmail Ee Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.Mssql.UserInfo>>(42);
                    __builder3.AddAttribute(43, "Property", "Cost");
                    __builder3.AddAttribute(44, "Title", "Cost");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Blackmail.Models.Mssql.UserInfo>>(46);
                    __builder3.AddAttribute(47, "Property", "img");
                    __builder3.AddAttribute(48, "Title", "Img");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(50, (__value) => {
#nullable restore
#line 23 "C:\Users\jenni\Documents\FrontEndWeb\Blackmail_FrontEnd\client\Pages\UserInfos.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Blackmail.Models.Mssql.UserInfo>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591