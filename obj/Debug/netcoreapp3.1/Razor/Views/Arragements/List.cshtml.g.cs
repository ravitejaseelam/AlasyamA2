#pragma checksum "D:\.netprojects\AkulaA2\Views\Arragements\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7408bfd826080a04b7d435f9230cfb64ae021391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Arragements_List), @"mvc.1.0.view", @"/Views/Arragements/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7408bfd826080a04b7d435f9230cfb64ae021391", @"/Views/Arragements/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585acdb48593a03db89b83a4c151211b8a4a8962", @"/Views/_ViewImports.cshtml")]
    public class Views_Arragements_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.netprojects\AkulaA2\Views\Arragements\List.cshtml"
  
    ViewData["Title"] = "Arrangements";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-detail\">\r\n    <div>\r\n        <table class=\"listTable\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 11 "D:\.netprojects\AkulaA2\Views\Arragements\List.cshtml"
                   Write(Model.SelectedCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Events</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n\r\n");
#nullable restore
#line 16 "D:\.netprojects\AkulaA2\Views\Arragements\List.cshtml"
             foreach (var arrangement in Model.Arrangements)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"td\">");
#nullable restore
#line 19 "D:\.netprojects\AkulaA2\Views\Arragements\List.cshtml"
                      Write(arrangement.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"td\">\r\n                ");
#nullable restore
#line 21 "D:\.netprojects\AkulaA2\Views\Arragements\List.cshtml"
           Write(arrangement.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"td\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 609, "\"", 636, 1);
#nullable restore
#line 24 "D:\.netprojects\AkulaA2\Views\Arragements\List.cshtml"
WriteAttributeValue("", 615, arrangement.ImageSrc, 615, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 637, "\"", 669, 1);
#nullable restore
#line 24 "D:\.netprojects\AkulaA2\Views\Arragements\List.cshtml"
WriteAttributeValue("", 645, arrangement.Description, 645, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "D:\.netprojects\AkulaA2\Views\Arragements\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
