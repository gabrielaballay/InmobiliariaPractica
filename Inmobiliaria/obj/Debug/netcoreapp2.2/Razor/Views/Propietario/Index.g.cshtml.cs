#pragma checksum "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ede1afc2fe2df6f024466f735b64b5c56b1db4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Propietario_Index), @"mvc.1.0.view", @"/Views/Propietario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Propietario/Index.cshtml", typeof(AspNetCore.Views_Propietario_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\_ViewImports.cshtml"
using Inmobiliaria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ede1afc2fe2df6f024466f735b64b5c56b1db4b", @"/Views/Propietario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98078dec4b7958a21d5ccb3aa268b567788e7d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Propietario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inmobiliaria.Models.Propietario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 363, true);
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""col-md-8"">
                <h4 class=""text-center mt-3"">Listado de Propietarios</h4>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(460, 42, false);
#line 15 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(502, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(606, 44, false);
#line 18 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(650, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(754, 40, false);
#line 21 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(794, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(898, 44, false);
#line 24 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(942, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1189, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1298, 41, false);
#line 34 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1455, 43, false);
#line 37 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1614, 39, false);
#line 40 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(1653, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1769, 43, false);
#line 43 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1812, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1928, 67, false);
#line 46 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                               Write(Html.ActionLink("Editar", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(2036, 72, false);
#line 47 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                               Write(Html.ActionLink("Detalles", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(2149, 69, false);
#line 48 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                               Write(Html.ActionLink("Borrar", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2218, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Gabriel\source\repos\Inmobiliaria\Inmobiliaria\Views\Propietario\Index.cshtml"
                   
                          }

#line default
#line hidden
            BeginContext(2344, 103, true);
            WriteLiteral("                     </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inmobiliaria.Models.Propietario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
