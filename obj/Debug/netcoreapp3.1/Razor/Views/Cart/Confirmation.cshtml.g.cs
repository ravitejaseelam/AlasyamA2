#pragma checksum "C:\Users\12149\source\repos\AlasyamA2\Views\Cart\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b437c92e912520e7e7970a99f25cc3840177bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Confirmation), @"mvc.1.0.view", @"/Views/Cart/Confirmation.cshtml")]
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
#line 1 "C:\Users\12149\source\repos\AlasyamA2\Views\_ViewImports.cshtml"
using AlasyamA2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\12149\source\repos\AlasyamA2\Views\_ViewImports.cshtml"
using AlasyamA2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b437c92e912520e7e7970a99f25cc3840177bd", @"/Views/Cart/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d88f6f14e8558fba487c9c8a126875d1f81205", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sale>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\12149\source\repos\AlasyamA2\Views\Cart\Confirmation.cshtml"
  
    ViewData["Title"] = "Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Order Confirmation</h2>\r\n<table>\r\n\r\n    <tr>\r\n        <td class=\"td2\"> Customer Name:</td>\r\n        <td> ");
#nullable restore
#line 11 "C:\Users\12149\source\repos\AlasyamA2\Views\Cart\Confirmation.cshtml"
        Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td class=\"td2\"> Message:</td>\r\n        <td> ");
#nullable restore
#line 16 "C:\Users\12149\source\repos\AlasyamA2\Views\Cart\Confirmation.cshtml"
        Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"td2\"> Boquet Type:</td>\r\n        <td> ");
#nullable restore
#line 20 "C:\Users\12149\source\repos\AlasyamA2\Views\Cart\Confirmation.cshtml"
        Write(Model.GetBouqte());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"td2\"> Delivery Charge:</td>\r\n        <td> ");
#nullable restore
#line 24 "C:\Users\12149\source\repos\AlasyamA2\Views\Cart\Confirmation.cshtml"
        Write(Model.Price().ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n    <tr>\r\n        <td class=\"td2\"> Bouquet Price:</td>\r\n        <td> ");
#nullable restore
#line 29 "C:\Users\12149\source\repos\AlasyamA2\Views\Cart\Confirmation.cshtml"
        Write(Model.GetRate().ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"td2\"> Total Rate:</td>\r\n        <td> ");
#nullable restore
#line 33 "C:\Users\12149\source\repos\AlasyamA2\Views\Cart\Confirmation.cshtml"
        Write(Model.GetTotal().ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sale> Html { get; private set; }
    }
}
#pragma warning restore 1591
