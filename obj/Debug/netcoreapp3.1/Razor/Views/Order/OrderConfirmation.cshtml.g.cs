#pragma checksum "D:\.netprojects\AkulaA2\Views\Order\OrderConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ccd1f6f141a1bb63975f2c12dc991b4f9fa108b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderConfirmation), @"mvc.1.0.view", @"/Views/Order/OrderConfirmation.cshtml")]
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
#line 1 "D:\.netprojects\AkulaA2\Views\_ViewImports.cshtml"
using AkulaA2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.netprojects\AkulaA2\Views\_ViewImports.cshtml"
using AkulaA2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ccd1f6f141a1bb63975f2c12dc991b4f9fa108b", @"/Views/Order/OrderConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585acdb48593a03db89b83a4c151211b8a4a8962", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sale>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.netprojects\AkulaA2\Views\Order\OrderConfirmation.cshtml"
  
    ViewData["Title"] = "Order Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-detail\">\r\n    <div>\r\n        Your order has been confirmed for the following :\r\n        <table>\r\n            <tr>\r\n                <td class=\"td2\">Customer Name</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 13 "D:\.netprojects\AkulaA2\Views\Order\OrderConfirmation.cshtml"
               Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"td2\">Selected Item</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 19 "D:\.netprojects\AkulaA2\Views\Order\OrderConfirmation.cshtml"
               Write(Model.SelectedOption?.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"td2\">Price</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "D:\.netprojects\AkulaA2\Views\Order\OrderConfirmation.cshtml"
               Write(Model.SelectedOption?.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"td2\">Address</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "D:\.netprojects\AkulaA2\Views\Order\OrderConfirmation.cshtml"
               Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n</div>");
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