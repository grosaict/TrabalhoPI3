#pragma checksum "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f892c7b006ce750aa7dfbced6ab7c93822f8d5af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductOrders_Index), @"mvc.1.0.view", @"/Views/ProductOrders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductOrders/Index.cshtml", typeof(AspNetCore.Views_ProductOrders_Index))]
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
#line 1 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\_ViewImports.cshtml"
using Margille;

#line default
#line hidden
#line 2 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\_ViewImports.cshtml"
using Margille.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f892c7b006ce750aa7dfbced6ab7c93822f8d5af", @"/Views/ProductOrders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92004c907ea3f6f6016fb750c41ad51455e8d388", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductOrders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Margille.Models.ProductOrder>>
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02e2837b744a4c8c9c3b76afe46e2dfb", async() => {
                BeginContext(145, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(159, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 43, false);
#line 16 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
            EndContext();
            BeginContext(295, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 41, false);
#line 19 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
            EndContext();
            BeginContext(392, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(448, 46, false);
#line 22 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductQtd));

#line default
#line hidden
            EndContext();
            BeginContext(494, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(550, 53, false);
#line 25 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(603, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(721, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(770, 54, false);
#line 34 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(824, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(880, 48, false);
#line 37 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(928, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(984, 45, false);
#line 40 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductQtd));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1085, 52, false);
#line 43 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1193, 65, false);
#line 46 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1279, 71, false);
#line 47 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1371, 69, false);
#line 48 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1479, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Margille.Models.ProductOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591