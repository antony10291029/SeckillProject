#pragma checksum "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b864aea465e4ba355f8eeb268baddd155b5cc54f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "F:\VS2019\Projects\Projects.SeckillFronts\Views\_ViewImports.cshtml"
using Projects.SeckillFronts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VS2019\Projects\Projects.SeckillFronts\Views\_ViewImports.cshtml"
using Projects.SeckillFronts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b864aea465e4ba355f8eeb268baddd155b5cc54f", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"183ce17c2c3afc2e776f3941ad0bc4688fde66b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/order.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"hidden\" id=\"ProductId\"");
            BeginWriteAttribute("value", " value=\"", 127, "\"", 157, 1);
#nullable restore
#line 7 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
WriteAttributeValue("", 135, ViewData["ProductId"], 135, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"ProductUrl\"");
            BeginWriteAttribute("value", " value=\"", 199, "\"", 230, 1);
#nullable restore
#line 8 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
WriteAttributeValue("", 207, ViewData["ProductUrl"], 207, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"ProductTitle\"");
            BeginWriteAttribute("value", " value=\"", 274, "\"", 307, 1);
#nullable restore
#line 9 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
WriteAttributeValue("", 282, ViewData["ProductTitle"], 282, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"ProductPrice\"");
            BeginWriteAttribute("value", " value=\"", 351, "\"", 384, 1);
#nullable restore
#line 10 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
WriteAttributeValue("", 359, ViewData["ProductPrice"], 359, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"ProductCount\"");
            BeginWriteAttribute("value", " value=\"", 428, "\"", 461, 1);
#nullable restore
#line 11 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
WriteAttributeValue("", 436, ViewData["ProductCount"], 436, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
<!-- 页面部分 -->
<div class=""xm-product-box"">
    <div class=""nav-bar"">
        <div class=""container"">
            <h2>我的购物车温馨提示：产品是否购买成功，以最终下单为准哦，请尽快结算</h2>
            <div class=""con"">
                <div class=""left""></div>
            </div>
        </div>
    </div>
</div>

<div class=""order-list"">
    <table>
        <tr>
            <th>图片</th>
            <th>产品名称</th>
            <th>单价</th>
            <th>数量</th>
            <th>小计</th>
        </tr>
        <tr>
            <td><img");
            BeginWriteAttribute("src", " src=\"", 988, "\"", 1017, 1);
#nullable restore
#line 34 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
WriteAttributeValue("", 994, ViewData["ProductUrl"], 994, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"120\" height=\"120\"");
            BeginWriteAttribute("alt", " alt=\"", 1043, "\"", 1049, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
           Write(ViewData["ProductTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                请您在 6月16日 17:38 前下单, 结果以支付成功为准\r\n            </td>\r\n            <td>");
#nullable restore
#line 39 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
           Write(ViewData["ProductPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("元</td>\r\n            <td>");
#nullable restore
#line 40 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
           Write(ViewData["ProductCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
           Write(ViewData["ProductPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("元</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"5\"><a href=\"javascript:void(0);\" class=\"btn-order\">立即下单</a></td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b864aea465e4ba355f8eeb268baddd155b5cc54f8145", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "F:\VS2019\Projects\Projects.SeckillFronts\Views\Order\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
