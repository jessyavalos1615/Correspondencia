#pragma checksum "C:\Users\jessy\Desktop\Servicio\Proyecto\Correspondencia\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9f1d31e071f0af2bda3f62f322345ba57754ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "C:\Users\jessy\Desktop\Servicio\Proyecto\Correspondencia\Views\_ViewImports.cshtml"
using Correspondencia;

#line default
#line hidden
#line 2 "C:\Users\jessy\Desktop\Servicio\Proyecto\Correspondencia\Views\_ViewImports.cshtml"
using Correspondencia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9f1d31e071f0af2bda3f62f322345ba57754ff", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b824325771201b73ba172ffc952498f219aa9534", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\jessy\Desktop\Servicio\Proyecto\Correspondencia\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
            BeginContext(42, 1691, true);
            WriteLiteral(@"
    <div class=""container text-center"">

        <br />
        <br />
        <br />

        <h4>Secretaria de Desarrollo Rural</h4>
        <h4>Sistema de control y seguimiento de Correspondencia</h4>

        <br />
        <br />
        <div data-spy=""scroll"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Enviado</th>
                        <th scope=""col"">Dirección destino</th>
                        <th scope=""col"">Remitente</th>
                        <th scope=""col"">Dirección remitente</th>
                        <th scope=""col"">Puesto remitente</th>
                        <th scope=""col"">Tipo de documento</th>
                        <th scope=""col"">Estado</th>
                        <th scope=""col"">Documento fisico</th>
                        <th scope=""col"">Fecha captura</th>
                        <th scope=""col"">Visualizar</th>
         ");
            WriteLiteral(@"           </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope=""row"">1</th>
                        <td>Si</td>
                        <td>Direccion1</td>
                        <td>Remitente1</td>
                        <td>Direccion2</td>
                        <td>Puesto1</td>
                        <td>Invitacion</td>
                        <td>Pendiente</td>
                        <td>Si</td>
                        <td>14/03/2018</td>
                        <td>Ver</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
