#pragma checksum "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e3c5017c5e96cac902193125b6013134b591b20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asset_ListAssets), @"mvc.1.0.view", @"/Views/Asset/ListAssets.cshtml")]
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
#line 1 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\_ViewImports.cshtml"
using Practise_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\_ViewImports.cshtml"
using Practise_Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e3c5017c5e96cac902193125b6013134b591b20", @"/Views/Asset/ListAssets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a6e0e596e251fc9dfce5050fa17759c6870691", @"/Views/_ViewImports.cshtml")]
    public class Views_Asset_ListAssets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Practise_Demo.Models.Asset>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml"
  
    ViewData["Title"] = "ListAssets";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListAssets</h1>\r\n\r\n");
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Name
            </th>
            <th>
                Description
            </th>
            <th>
                Tag Number
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml"
           Write(item.TagNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            ");
#nullable restore
#line 46 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml"
       Write(Html.ActionLink("Edit", "EditAsset", new {  id=item.Id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 47 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml"
       Write(Html.ActionLink("Delete", "DeleteAsset", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\deepd\source\repos\Practise Demo\Practise Demo\Views\Asset\ListAssets.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Practise_Demo.Models.Asset>> Html { get; private set; }
    }
}
#pragma warning restore 1591
