#pragma checksum "D:\NashTech\dotNetMVC\Views\Rookies\GetFullName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff0f309253d5eb7db1c6616fb8132dc40ff00c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_GetFullName), @"mvc.1.0.view", @"/Views/Rookies/GetFullName.cshtml")]
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
#line 1 "D:\NashTech\dotNetMVC\Views\_ViewImports.cshtml"
using dotNetMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NashTech\dotNetMVC\Views\_ViewImports.cshtml"
using dotNetMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0f309253d5eb7db1c6616fb8132dc40ff00c98", @"/Views/Rookies/GetFullName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b38d1bd8be5a7509552ec77f57abb36da1cd34", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_GetFullName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\NashTech\dotNetMVC\Views\Rookies\GetFullName.cshtml"
    
    Layout = null;  

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NashTech\dotNetMVC\Views\Rookies\GetFullName.cshtml"
      
        foreach (var i in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 7 "D:\NashTech\dotNetMVC\Views\Rookies\GetFullName.cshtml"
           Write(i.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "D:\NashTech\dotNetMVC\Views\Rookies\GetFullName.cshtml"
                        Write(i.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 8 "D:\NashTech\dotNetMVC\Views\Rookies\GetFullName.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
