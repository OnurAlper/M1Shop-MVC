#pragma checksum "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f216993aae81d9e305bc8798601597858bccc57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\_ViewImports.cshtml"
using M1Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\_ViewImports.cshtml"
using M1Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f216993aae81d9e305bc8798601597858bccc57", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10543a015d4adb32d6aae5c79ac910b1233fd8e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<M1Shop.Models.Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n\r\n    <hr />\r\n    <table class=\"table table-bordered table-responsive table-hover\">\r\n        <thead>\r\n            <tr >\r\n                <th class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.QuantityPerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.QuantityPerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            <tr>\r\n                <th class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.UnitsOnOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.UnitsOnOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ReorderLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.ReorderLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 72 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 75 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 80 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 83 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.Supplier.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </thead>\r\n       \r\n    </table>\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f216993aae81d9e305bc8798601597858bccc5711013", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\Alper Onur Başköy\Source\Repos\M1Shop\M1Shop\Views\Products\Details.cshtml"
                           WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f216993aae81d9e305bc8798601597858bccc5713167", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<M1Shop.Models.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
