#pragma checksum "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\StateManagement\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac1532feefe897664db5314a854d533053fb9d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StateManagement_Logout), @"mvc.1.0.view", @"/Views/StateManagement/Logout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StateManagement/Logout.cshtml", typeof(AspNetCore.Views_StateManagement_Logout))]
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
#line 1 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\_ViewImports.cshtml"
using MVCLab23;

#line default
#line hidden
#line 2 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\_ViewImports.cshtml"
using MVCLab23.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac1532feefe897664db5314a854d533053fb9d8", @"/Views/StateManagement/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd06da2fd60f5684890fa4e5bbaa357df7595844", @"/Views/_ViewImports.cshtml")]
    public class Views_StateManagement_Logout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\StateManagement\Logout.cshtml"
 if (TempData.Peek("name") != null)
{

#line default
#line hidden
            BeginContext(40, 15, true);
            WriteLiteral("    <p>GoodBye ");
            EndContext();
            BeginContext(56, 16, false);
#line 3 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\StateManagement\Logout.cshtml"
          Write(TempData["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(72, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 4 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\StateManagement\Logout.cshtml"
}

#line default
#line hidden
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
