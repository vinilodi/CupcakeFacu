#pragma checksum "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee306973cfdaa162390e863e1744215df2aa5e8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Order/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_Order_Index))]
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
#line 1 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\_ViewImports.cshtml"
using Cupcakecom;

#line default
#line hidden
#line 1 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
using Cupcakecom.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee306973cfdaa162390e863e1744215df2aa5e8f", @"/Areas/Customer/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"481955db10887bd6620e70075200fd690a0df5a3", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 131, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Order List</h2>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
            BeginContext(226, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee306973cfdaa162390e863e1744215df2aa5e8f4190", async() => {
                BeginContext(246, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(255, 174, true);
            WriteLiteral("\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\" id=\"myTable\">\r\n        <thead>\r\n            <tr class=\"table-info\">\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(430, 35, false);
#line 23 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.OrderNo));

#line default
#line hidden
            EndContext();
            BeginContext(465, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(533, 32, false);
#line 26 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(565, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(633, 37, false);
#line 29 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(670, 81, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(808, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(855, 12, false);
#line 38 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
                   Write(item.OrderNo);

#line default
#line hidden
            EndContext();
            BeginContext(867, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(899, 9, false);
#line 39 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(908, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(940, 14, false);
#line 40 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
                   Write(item.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(954, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 42 "C:\Users\vinic\Documents\Projects\onlineshop\OnlineShop\Areas\Customer\Views\Order\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(999, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
