#pragma checksum "D:\Área de Trabalho\PI\projeto_integrador\ProjIntegrador\Views\Home\ListarPessoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e5b594316e1240984633f8610c42b7ab6b6ce01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListarPessoa), @"mvc.1.0.view", @"/Views/Home/ListarPessoa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListarPessoa.cshtml", typeof(AspNetCore.Views_Home_ListarPessoa))]
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
#line 1 "D:\Área de Trabalho\PI\projeto_integrador\ProjIntegrador\Views\_ViewImports.cshtml"
using ProjIntegrador;

#line default
#line hidden
#line 2 "D:\Área de Trabalho\PI\projeto_integrador\ProjIntegrador\Views\_ViewImports.cshtml"
using ProjIntegrador.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5b594316e1240984633f8610c42b7ab6b6ce01", @"/Views/Home/ListarPessoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc91c0cc360f7570dbfc49013f320f85473c151", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListarPessoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 540, true);
            WriteLiteral(@"<!-- CSS only -->
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6"" crossorigin=""anonymous""><div class=""row"" id="""">

    <table class=""table table-condensed table-bordered table-striped dataTable"">
        <thead>
            <tr>
                <th width=""15%"">Ações</th>
                <th class=""text-center"" width=""20%"">Nome</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 12 "D:\Área de Trabalho\PI\projeto_integrador\ProjIntegrador\Views\Home\ListarPessoa.cshtml"
             foreach (var item in ViewBag.LstUsuarios)
            {

#line default
#line hidden
            BeginContext(611, 68, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">\r\n");
            EndContext();
            BeginContext(794, 97, true);
            WriteLiteral("                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(892, 9, false);
#line 19 "D:\Área de Trabalho\PI\projeto_integrador\ProjIntegrador\Views\Home\ListarPessoa.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(901, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 22 "D:\Área de Trabalho\PI\projeto_integrador\ProjIntegrador\Views\Home\ListarPessoa.cshtml"
            }

#line default
#line hidden
            BeginContext(968, 296, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<!-- JavaScript Bundle with Popper -->
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf"" crossorigin=""anonymous""></script>");
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