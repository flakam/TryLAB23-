#pragma checksum "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\StateManagement\Password.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f5e06ede276cf1b53672f831440168930ac98eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StateManagement_Password), @"mvc.1.0.view", @"/Views/StateManagement/Password.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StateManagement/Password.cshtml", typeof(AspNetCore.Views_StateManagement_Password))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5e06ede276cf1b53672f831440168930ac98eb", @"/Views/StateManagement/Password.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd06da2fd60f5684890fa4e5bbaa357df7595844", @"/Views/_ViewImports.cshtml")]
    public class Views_StateManagement_Password : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 20, true);
            WriteLiteral("<p>Your Password is ");
            EndContext();
            BeginContext(21, 25, false);
#line 1 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\StateManagement\Password.cshtml"
               Write(TempData.Peek("password"));

#line default
#line hidden
            EndContext();
            BeginContext(46, 4, true);
            WriteLiteral("</p>");
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
