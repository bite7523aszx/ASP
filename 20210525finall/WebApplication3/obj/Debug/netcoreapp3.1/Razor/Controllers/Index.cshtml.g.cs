#pragma checksum "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Controllers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6a3c1c2a87a5195948b175249dcbb9b61820b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Index), @"mvc.1.0.view", @"/Controllers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc6a3c1c2a87a5195948b175249dcbb9b61820b7", @"/Controllers/Index.cshtml")]
    public class Controllers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Controllers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/game_index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>結帳</h1>
<style>
    #cart {
        background-color: white;
    }

    #shop tr, th {
        padding: 8px;
    }

        #shop tr:hover {
            background-color: lightblue;
        }

    #shop td {
        color: black
    }
</style>

<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.3/css/all.css"" integrity=""sha384-SZXxX4whJ79/gErwcOYf+zWLeJdY/qpuqC4cAa9rOGUstPomtqpuNWT9wdPEn2fk"" crossorigin=""anonymous"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc6a3c1c2a87a5195948b175249dcbb9b61820b73297", async() => {
                WriteLiteral(@"

    <div id=""cart"" class=""container"">
        <h1>確認商品</h1>

        <div class=""row"">

            <div class=""col-sm-8"">

                <h4>Check out</h4>
            </div>
            <div class=""col-sm-4 contShop"">
                <p><a asp-controller=""Game_mallView"" asp-action=""index"">繼續購物</a>
            </div>
        </div>
        <form>
            <table id=""shop"" border=""1"" class=""table table-bordered table-info table-hover"">
                <thead class=""table bg-danger"">
                    <tr>
                        <th>遊戲名稱</th>
                        <th>遊戲類型</th>
                        <th>數量</th>
                        <th>價錢</th>
");
                WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody class=\"bg-white\">\r\n");
#nullable restore
#line 54 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Controllers\Index.cshtml"
                     foreach (var item in ViewBag.cart)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Controllers\Index.cshtml"
                           Write(item.Product.Game_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 58 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Controllers\Index.cshtml"
                           Write(item.Product.Game_category);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 59 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Controllers\Index.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 60 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Controllers\Index.cshtml"
                            Write(item.Product.Unit_price * item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
                WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Controllers\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td align=\"right\" colspan=\"5\">\r\n                            小計 :");
#nullable restore
#line 68 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Controllers\Index.cshtml"
                           Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td align=\"right\" colspan=\"5\">\r\n                            <a onclick=\"return confirm(\'確定結帳\')\" asp-controller=\"check\" asp-action=\"check\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2479, "\"", 2494, 0);
                EndWriteAttribute();
                WriteLiteral(">確定結帳</a>\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </form>\r\n\r\n        <bt />\r\n");
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
