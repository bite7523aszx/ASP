#pragma checksum "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c5d3188d302aca7d472c370c6d92d03167acf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Story_Game_Story20), @"mvc.1.0.view", @"/Views/Game_Story/Game_Story20.cshtml")]
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
#line 1 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c5d3188d302aca7d472c370c6d92d03167acf8", @"/Views/Game_Story/Game_Story20.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Story_Game_Story20 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Game_mall>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Game_Story/Game_Story20/Game_Story20-1.mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Game_index/cart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "stroyaddcart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
  
    ViewData["Title"] = "Game_Story20";
    Layout = "Game_index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
 foreach (var item in Model)
{
    if (item.Game_number == 20)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <section id=""Game_Story_title"">
            <div class=""container text-warning"">
                <div class=""row"">
                    <div class=""col-md-10 offset-md-1"">
                        <div class=""row container"">
                            <div class=""col-md-12"">
                                <h1>");
#nullable restore
#line 16 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Game_name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section id=""Game_Story_imgmax"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-10 offset-md-1"">
                        <div class=""col-md-12"">
                            <div class=""swiper-container gallery-top"">
                                <div class=""swiper-wrapper"">
");
#nullable restore
#line 30 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                                     for (int i = 1; i <= 8; i++)
                                    {
                                        string img = $"Game_Story20-{i}.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"swiper-slide\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9c5d3188d302aca7d472c370c6d92d03167acf88024", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1355, "~/img/Game_Story/Game_Story20/", 1355, 30, true);
#nullable restore
#line 33 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
AddHtmlAttributeValue("", 1385, img, 1385, 4, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 34 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                                <!-- Add Arrows -->
                                <div class=""swiper-button-next swiper-button-white swiper-opacity""></div>
                                <div class=""swiper-button-prev swiper-button-white swiper-opacity""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section id=""Game_Story_imgmin"">
            <div class=""container "">
                <div class=""row"">
                    <div class=""col-md-10 offset-md-1"">
                        <div class=""col-md-12"">
                            <div class=""swiper-container gallery-thumbs"">
                                <div class=""swiper-wrapper"">
");
#nullable restore
#line 52 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                                     for (int i = 1; i <= 8; i++)
                                    {
                                        string img = $"Game_Story20-{i}.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"swiper-slide\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9c5d3188d302aca7d472c370c6d92d03167acf811074", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2524, "~/img/Game_Story/Game_Story20/", 2524, 30, true);
#nullable restore
#line 55 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
AddHtmlAttributeValue("", 2554, img, 2554, 4, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 56 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Initialize Swiper -->
        <script>
            var galleryThumbs = new Swiper('.gallery-thumbs', {
                spaceBetween: 8,
                slidesPerView: 3,
                loop: true,
                freeMode: true,
                loopedSlides: 4, //looped slides should be the same
                watchSlidesVisibility: true,
                watchSlidesProgress: true,
            });
            var galleryTop = new Swiper('.gallery-top', {
                spaceBetween: 8,
                loop: true,
                loopedSlides: 4, //looped slides should be the same
                navigation: {
                    nextEl: '.swiper-button-next',
                    prevEl: '.swiper-button-prev',
                },
                thumbs: {
                    swipe");
            WriteLiteral(@"r: galleryThumbs,
                },
            });
        </script>
        <section id=""Game_Story_sec1"">
            <div class=""container text-white"">
                <div class=""row"">
                    <div class=""col-md-10 offset-md-1"">
                        <div class=""row container"">
                            <div class=""col-md-8 margin10px0"">
                                <h3 class=""text-warning"">遊戲介紹</h3>
                                <h5>Home Sweet Home is back with its soul-stirring sequel that will haunt you to the ground ! Immerse yourself in a world of Thai myths, let's fight together to get out of this horrifying world. The 4vs1 game from a Thai studio that will give you the experience of hunting and being hunted in one game.</h5>
                            </div>
                            <div class=""col-md-4 margin10px0"">
                                <video autoplay muted loop id=""Game_Story_mp4"" class=""margin10px0"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9c5d3188d302aca7d472c370c6d92d03167acf814921", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    您的瀏覽器不支援此影音播放模式!\r\n                                </video>\r\n                                <h6>遊戲類型：");
#nullable restore
#line 102 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Game_category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6>發行日期：");
#nullable restore
#line 103 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Listing_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"row h3_color margin10px0\" style=\"width:100%\">\r\n                                <div class=\"col-md-8\">\r\n                                    <h3>購買：");
#nullable restore
#line 107 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Game_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </div>\r\n                                <div class=\"col-md-4\">\r\n                                    <span>");
#nullable restore
#line 110 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Unit_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9c5d3188d302aca7d472c370c6d92d03167acf817772", async() => {
                WriteLiteral("\r\n\r\n                                        <input type=\"hidden\" name=\"Game_number\"");
                BeginWriteAttribute("value", " value=\"", 5645, "\"", 5670, 1);
#nullable restore
#line 113 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
WriteAttributeValue("", 5653, item.Game_number, 5653, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <div>\r\n                                            <input placeholder=\"購買數量\" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 5806, "\"", 5814, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""width:100px"">
                                            <button type=""submit"" style=""border: none"" data-placement=""bottom"" data-toggle=""popover"" data-trigger=""hover"" title=""購物車"" data-content=""點擊圖片加入購物車"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9c5d3188d302aca7d472c370c6d92d03167acf819089", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </button>\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9c5d3188d302aca7d472c370c6d92d03167acf821732", async() => {
                WriteLiteral("直接購買");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
                                                                                                        WriteLiteral(item.Game_number);

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
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-12 margin10px0"">
                                <h3 class=""text-warning"">關於此遊戲</h3>
                                <h6>Home Sweet Home: Survive is a brand new asymmetrical game that consists of 1 Specter hunting 4 survivors in an arena. There are two core gameplays depended on the role players take.</h6>
                                <h6>The Specter is to strategically hunt 4 Survivors letting no one escape, and not being killed by survivors. Each Specter will have different stats and special abilities offering various ways of hunting survivors.</h6>
                                <h6>The survivors have to cooperate to complete the objective. Each character will have different stats and unique abilities supporting each role of play - decoy, damage, or perform the rituals. Things will drastically change after the objective is completed. The game will test personal dilemma choosi");
            WriteLiteral(@"ng either teaming up to eliminate the Specter or saving own self by leaving the arena. escaping the Hindrance, or be the Specter and hunt and collect souls.</h6><br>
                                <h6>Key Features</h6>
                                <ul>
                                    <li>Multiplayer – Enjoy the game in multiplayer, cooperating with other survivors or being a lone wolf hunting down survivors</li><br>
                                    <li>Differentiated Gameplay – Asymmetrical gameplay does not need to be an escape game. The Specter cannot play recklessly; survivors can hunt you down as well. Good team play is the winning key for survivors.</li><br>
                                    <li>Repeatable Gameplay – Each game will not be the same even playing with the same group of people. Experiencing the game that situations are always changed with various settings and characters.</li><br>
                                </ul>
                            </div>
                   ");
            WriteLiteral("     </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 141 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story20.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""Game_Story_sec2"">
    <div class=""container text-white"">
        <div class=""row"">
            <div class=""col-md-10 offset-md-1"">
                <div class=""col-md-12 margin10px0"">
                    <ul class=""nav nav-tabs"">
                        <li class=""nav-item"">
                            <a class=""nav-link active text-info"" data-toggle=""tab"" href=""#Windows"">Windows</a>
                        </li>
                    </ul>
                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""Windows"">
                            <div class=""row"">
                                <div class=""col-md-6 margin10px0"">
                                    <h6>最低配備: 需要 64 位元的處理器及作業系統</h6>
                                    <h6>作業系統: Windows 10 (64-bit Version)</h6>
                                    <h6>處理器: Intel i3-6100</h6>
                                    <h6>記憶體: 8 GB 記憶體</h6>
                                    <h6>顯示卡: NVIDIA GT");
            WriteLiteral(@"X 660 2GB</h6>
                                    <h6>網路: 寬頻網際網路連線</h6>
                                    <h6>儲存空間: 7 GB 可用空間</h6>
                                </div>
                                <div class=""col-md-6 margin10px0"">
                                    <h6>建議配備:</h6>
                                    <h6>作業系統: Windows 10 (64-bit Version)</h6>
                                    <h6>處理器: Intel i5-8400</h6>
                                    <h6>記憶體: 8 GB 記憶體</h6>
                                    <h6>顯示卡: NVIDIA GTX 1060 6GB</h6>
                                    <h6>網路: 寬頻網際網路連線</h6>
                                    <h6>儲存空間: 7 GB 可用空間</h6>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</section>
<section id=""Game_Story_sec3"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10 ");
            WriteLiteral(@"offset-md-1"">
                <div class=""row container"">
                    <div class=""col-md-12 margin10px0"">
                        <h3 class=""text-warning"">精彩影片</h3>
                    </div>
                    <div class=""col-md-6"">
                        <p><iframe src=""https://www.youtube.com/embed/6AqJXUrwPWU"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe></p>
                    </div>
                    <div class=""col-md-6"">
                        <p><iframe src=""https://www.youtube.com/embed/l8JO0v6hzqg"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe></p>
                    </div>
                    <div class=""col-md-6"">
                        <p><iframe src=""https://www.youtube.com/embed/u4iZIiAKmcY"" title=""YouTube video player"" framebo");
            WriteLiteral(@"rder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe></p>
                    </div>
                    <div class=""col-md-6"">
                        <p><iframe src=""https://www.youtube.com/embed/SfUSeQQJtyc"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.Game_mall>> Html { get; private set; }
    }
}
#pragma warning restore 1591
