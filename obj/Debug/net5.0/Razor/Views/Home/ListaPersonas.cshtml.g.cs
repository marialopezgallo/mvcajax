#pragma checksum "C:\Users\Admin\Desktop\mvcajax\Views\Home\ListaPersonas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "565ffbdfee13d70d0859325b8d625924802550ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaPersonas), @"mvc.1.0.view", @"/Views/Home/ListaPersonas.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\mvcajax\Views\_ViewImports.cshtml"
using mvcajax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\mvcajax\Views\_ViewImports.cshtml"
using mvcajax.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"565ffbdfee13d70d0859325b8d625924802550ff", @"/Views/Home/ListaPersonas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06d1cc3d6a2a01d648b8491edd30ba767dda40fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaPersonas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\Desktop\mvcajax\Views\Home\ListaPersonas.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>


    <script type=""text/javascript"">
        $(document).ready(function ()
         {

            
            $(""#boton"").click(function(){
            
                    $.getJSON(""/Home/ListaPersonasJson"", function(datos) {

                        console.log(datos);
                    
                         for( let i=0; i <datos.length; i++) {
                
                    $(""ul"").append(""<li>""+ datos[i].nombre +""</li>""+""<li>""+ datos[i].apellidos +""</li"");
                         }
            });
        })
        })
    </script>
<ul>
        
");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\mvcajax\Views\Home\ListaPersonas.cshtml"
     foreach (var persona in ViewBag.ListaPersonas)

    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 35 "C:\Users\Admin\Desktop\mvcajax\Views\Home\ListaPersonas.cshtml"
       Write(persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Admin\Desktop\mvcajax\Views\Home\ListaPersonas.cshtml"
                       Write(persona.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\mvcajax\Views\Home\ListaPersonas.cshtml"
    
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
     </ul>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  table>

    <input type=""button"" value=""aceptar"" id =""boton""/>
");
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
