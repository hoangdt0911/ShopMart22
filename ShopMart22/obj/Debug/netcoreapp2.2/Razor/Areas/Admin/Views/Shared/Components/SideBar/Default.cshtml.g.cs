#pragma checksum "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b5d62064b84601f2f8ad586255f833fd42e0480"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default))]
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
#line 1 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using ShopMart22;

#line default
#line hidden
#line 3 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using ShopMart22.Models;

#line default
#line hidden
#line 4 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using ShopMart22.Data.Entities;

#line default
#line hidden
#line 5 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using ShopMart22.Application.ViewModels.System;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5d62064b84601f2f8ad586255f833fd42e0480", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10def06a71f1c590d257b25b549eadce64fa6a33", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FunctionViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 190, true);
            WriteLiteral("<!-- sidebar menu -->\r\n<div id=\"sidebar-menu\" class=\"main_menu_side hidden-print main_menu\">\r\n    <div class=\"menu_section\">\r\n        <h3>Functions</h3>\r\n        <ul class=\"nav side-menu\">\r\n");
            EndContext();
#line 7 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
             foreach (var item in Model.Where(x =>string.IsNullOrEmpty(x.ParentId)))
            {

#line default
#line hidden
            BeginContext(323, 39, true);
            WriteLiteral("            <li>\r\n                <a><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 362, "\"", 386, 2);
            WriteAttributeValue("", 370, "fa", 370, 2, true);
#line 10 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue(" ", 372, item.IconCss, 373, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(387, 6, true);
            WriteLiteral("></i> ");
            EndContext();
            BeginContext(394, 9, false);
#line 10 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(403, 47, true);
            WriteLiteral(" <span class=\"fa fa-chevron-down\"></span></a>\r\n");
            EndContext();
#line 11 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                 if (Model.Any(x => x.ParentId == item.Id))
                {

#line default
#line hidden
            BeginContext(530, 49, true);
            WriteLiteral("                    <ul class=\"nav child_menu\">\r\n");
            EndContext();
#line 14 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                         foreach(var jitem in Model.Where(x => x.ParentId == item.Id))
                        {

#line default
#line hidden
            BeginContext(694, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 728, "\"", 745, 1);
#line 16 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 735, jitem.URL, 735, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(746, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(748, 10, false);
#line 16 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                Write(jitem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(758, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 17 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                            
                        }

#line default
#line hidden
            BeginContext(826, 53, true);
            WriteLiteral("                        \r\n                    </ul>\r\n");
            EndContext();
#line 21 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(898, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 24 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(934, 59, true);
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n</div>\r\n<!-- /sidebar menu -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FunctionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
