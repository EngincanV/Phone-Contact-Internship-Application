#pragma checksum "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\Personal\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bab90b5c84646e754f41461951419f9633735b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Detail), @"mvc.1.0.view", @"/Views/Personal/Detail.cshtml")]
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
#line 1 "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\_ViewImports.cshtml"
using Nuevo.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\_ViewImports.cshtml"
using Nuevo.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bab90b5c84646e754f41461951419f9633735b4", @"/Views/Personal/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f0db17bd9f16f4bb6164b0d74590fbdd6954d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalDetailView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\Personal\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"card text-center col-8 text-center mx-auto\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 9 "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\Personal\Detail.cshtml"
                              Write(Model.Personal.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\Personal\Detail.cshtml"
                                                   Write(Model.Personal.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
        </div>
        <table class=""table table-borderless table-hover"">
            <tr>
                <th>Phone</th>
                <th>Departmant</th>
                <th colspan=""2"">Manager</th>
            </tr>
            <tr>
                <td>
                    ");
#nullable restore
#line 19 "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\Personal\Detail.cshtml"
               Write(Model.Personal.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 22 "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\Personal\Detail.cshtml"
               Write(Model.Departmant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\Personal\Detail.cshtml"
               Write(Model.Manager.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\engin\source\repos\Nuevo\Nuevo.WebUI\Views\Personal\Detail.cshtml"
                                   Write(Model.Manager.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalDetailView> Html { get; private set; }
    }
}
#pragma warning restore 1591
