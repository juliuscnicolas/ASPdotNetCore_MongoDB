#pragma checksum "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e87f6dd37b445e08a5d61437b64d7d3b8bdd62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/Index.cshtml", typeof(AspNetCore.Views_Cars_Index))]
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
#line 1 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\_ViewImports.cshtml"
using CarGalleryApp;

#line default
#line hidden
#line 2 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\_ViewImports.cshtml"
using CarGalleryApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8e87f6dd37b445e08a5d61437b64d7d3b8bdd62", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeebbc10efe2ba5183f2764a829fc18ca28eec02", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarGalleryApp.Models.Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
  
    ViewData["Title"] = "Car Gallery";

#line default
#line hidden
            BeginContext(95, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(124, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e87f6dd37b445e08a5d61437b64d7d3b8bdd623968", async() => {
                BeginContext(147, 11, true);
                WriteLiteral("Add New Car");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 94, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 44, false);
#line 17 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(301, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(357, 41, false);
#line 20 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(398, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(454, 41, false);
#line 23 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(495, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(551, 40, false);
#line 26 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(591, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(647, 41, false);
#line 29 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(688, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(806, 34, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n");
            EndContext();
#line 39 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
                 if (item.ImageUrl != null)
                {

#line default
#line hidden
            BeginContext(904, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 928, "\"", 961, 1);
#line 41 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
WriteAttributeValue("", 934, Url.Content(item.ImageUrl), 934, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(962, 17, true);
            WriteLiteral(" alt=\"Image\" />\r\n");
            EndContext();
#line 42 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(998, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1052, 40, false);
#line 45 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1148, 40, false);
#line 48 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1244, 39, false);
#line 51 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1339, 40, false);
#line 54 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1437, 53, false);
#line 58 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1511, 59, false);
#line 59 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1591, 57, false);
#line 60 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\Julius\Documents\Projects\ASPdotNetCore_MongoDB\AspNetCoreWebAppMongoDB\CarGalleryApp\Views\Cars\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1687, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarGalleryApp.Models.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
