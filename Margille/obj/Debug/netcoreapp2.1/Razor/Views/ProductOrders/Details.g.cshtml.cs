#pragma checksum "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0fcd29587cf892c7e126015c5b511ec53ac7ef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductOrders_Details), @"mvc.1.0.view", @"/Views/ProductOrders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductOrders/Details.cshtml", typeof(AspNetCore.Views_ProductOrders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0fcd29587cf892c7e126015c5b511ec53ac7ef4", @"/Views/ProductOrders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92004c907ea3f6f6016fb750c41ad51455e8d388", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductOrders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Margille.Models.ProductOrder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>ProductOrder</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(209, 43, false);
#line 14 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
            EndContext();
            BeginContext(252, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(296, 51, false);
#line 17 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(347, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(391, 41, false);
#line 20 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
            EndContext();
            BeginContext(432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(476, 45, false);
#line 23 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(521, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(565, 46, false);
#line 26 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductQtd));

#line default
#line hidden
            EndContext();
            BeginContext(611, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(655, 42, false);
#line 29 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductQtd));

#line default
#line hidden
            EndContext();
            BeginContext(697, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(741, 53, false);
#line 32 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(794, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(838, 49, false);
#line 35 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(887, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(935, 68, false);
#line 40 "C:\Users\gsenn\Desktop\my files\workspace\PI3-Trabalho\Margille\Margille\Views\ProductOrders\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1011, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4186238b8ab34f70935fb50813c22347", async() => {
                BeginContext(1033, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1049, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Margille.Models.ProductOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
