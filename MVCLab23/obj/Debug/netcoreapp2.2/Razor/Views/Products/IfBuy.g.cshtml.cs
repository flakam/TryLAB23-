#pragma checksum "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\Products\IfBuy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95d3f7af1ef3e805dc331d4273ebb582c391e425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_IfBuy), @"mvc.1.0.view", @"/Views/Products/IfBuy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/IfBuy.cshtml", typeof(AspNetCore.Views_Products_IfBuy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d3f7af1ef3e805dc331d4273ebb582c391e425", @"/Views/Products/IfBuy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd06da2fd60f5684890fa4e5bbaa357df7595844", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_IfBuy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCLab23.Models.Products>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(35, 100, true);
            WriteLiteral("\r\n<h3>Thank you!Here is your receipt:   </h3>\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(136, 40, false);
#line 7 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\Products\IfBuy.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(176, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(226, 36, false);
#line 10 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\Products\IfBuy.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(262, 48, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(311, 41, false);
#line 13 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\Products\IfBuy.cshtml"
   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(352, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(402, 37, false);
#line 16 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\Products\IfBuy.cshtml"
   Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(439, 39, true);
            WriteLiteral("\r\n    </dd>\r\n</dl>\r\n<div>\r\n    <span>  ");
            EndContext();
            BeginContext(479, 10, false);
#line 20 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\Products\IfBuy.cshtml"
       Write(ViewBag.id);

#line default
#line hidden
            EndContext();
            BeginContext(489, 23, true);
            WriteLiteral("</span>\r\n  \r\n    <span>");
            EndContext();
            BeginContext(513, 12, false);
#line 22 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\Products\IfBuy.cshtml"
     Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(525, 21, true);
            WriteLiteral("</span> \r\n    <span> ");
            EndContext();
            BeginContext(547, 13, false);
#line 23 "C:\Users\Flaka\source\repos\MVCLab23\MVCLab23\Views\Products\IfBuy.cshtml"
      Write(ViewBag.price);

#line default
#line hidden
            EndContext();
            BeginContext(560, 21, true);
            WriteLiteral("</span>\r\n</div>\r\n  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCLab23.Models.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
