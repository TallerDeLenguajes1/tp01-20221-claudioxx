#pragma checksum "C:\Users\claud\Source\Repos\Taller2-2021\TP1\tp01-20221-claudioxx\Views\Home\Problema3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67140b78df7d3c7d5e746c5711e67b688ec03366"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Problema3), @"mvc.1.0.view", @"/Views/Home/Problema3.cshtml")]
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
#nullable restore
#line 1 "C:\Users\claud\Source\Repos\Taller2-2021\TP1\tp01-20221-claudioxx\Views\_ViewImports.cshtml"
using TP1_ArmandoClaudio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\claud\Source\Repos\Taller2-2021\TP1\tp01-20221-claudioxx\Views\_ViewImports.cshtml"
using TP1_ArmandoClaudio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67140b78df7d3c7d5e746c5711e67b688ec03366", @"/Views/Home/Problema3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"761049786b81171293d3314c5beb165249db5d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Problema3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TP1_ArmandoClaudio.Provincia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">ID</th>\r\n            <th scope=\"col\">Nombre</th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 10 "C:\Users\claud\Source\Repos\Taller2-2021\TP1\tp01-20221-claudioxx\Views\Home\Problema3.cshtml"
      
        // ProvinciasArgentinas ListProv = Model;
        foreach (Provincia prov in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n                <td>");
#nullable restore
#line 15 "C:\Users\claud\Source\Repos\Taller2-2021\TP1\tp01-20221-claudioxx\Views\Home\Problema3.cshtml"
               Write(prov.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\claud\Source\Repos\Taller2-2021\TP1\tp01-20221-claudioxx\Views\Home\Problema3.cshtml"
               Write(prov.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\claud\Source\Repos\Taller2-2021\TP1\tp01-20221-claudioxx\Views\Home\Problema3.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TP1_ArmandoClaudio.Provincia>> Html { get; private set; }
    }
}
#pragma warning restore 1591