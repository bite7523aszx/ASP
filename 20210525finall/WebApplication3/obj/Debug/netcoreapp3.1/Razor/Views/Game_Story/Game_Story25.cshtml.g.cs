#pragma checksum "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90461e40cb1cb3d9e8082050093ab41c8fe59d3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Story_Game_Story25), @"mvc.1.0.view", @"/Views/Game_Story/Game_Story25.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90461e40cb1cb3d9e8082050093ab41c8fe59d3f", @"/Views/Game_Story/Game_Story25.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Story_Game_Story25 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Game_mall>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Game_Story/Game_Story25/Game_Story25-1.mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
  
    ViewData["Title"] = "Game_Story25";
    Layout = "Game_index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
 foreach (var item in Model)
{
    if (item.Game_number == 25)
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
#line 16 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
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
#line 30 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
                                     for (int i = 1; i <= 8; i++)
                                    {
                                        string img = $"Game_Story25-{i}.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"swiper-slide\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90461e40cb1cb3d9e8082050093ab41c8fe59d3f8024", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1355, "~/img/Game_Story/Game_Story25/", 1355, 30, true);
#nullable restore
#line 33 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
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
#line 34 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
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
#line 52 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
                                     for (int i = 1; i <= 8; i++)
                                    {
                                        string img = $"Game_Story25-{i}.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"swiper-slide\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90461e40cb1cb3d9e8082050093ab41c8fe59d3f11074", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2524, "~/img/Game_Story/Game_Story25/", 2524, 30, true);
#nullable restore
#line 55 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
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
#line 56 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
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
                                <h5>《大衍江湖》是一款武侠题材，结合经营养成，角色扮演的游戏。玩家将操控一个江湖门派；与江湖上的其他各色各样的门派打交道，或建立贸易或直接攻陷；与其他门派弟子交流，或结交或抢夺；江湖世界上各种随机事件，能获得具体好处同时也伴随着各种风险；门派传承，终有一日，将主宰江湖。</h5>
                            </div>
                            <div class=""col-md-4 margin10px0"">
                                <video autoplay muted loop id=""Game_Story_mp4"" class=""margin10px0"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90461e40cb1cb3d9e8082050093ab41c8fe59d3f14756", async() => {
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
#line 102 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Game_category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6>發行日期：");
#nullable restore
#line 103 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Listing_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"row h3_color margin10px0\" style=\"width:100%\">\r\n                                <div class=\"col-md-8\">\r\n                                    <h3>購買：");
#nullable restore
#line 107 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Game_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </div>\r\n                                <div class=\"col-md-4\">\r\n                                    <span>");
#nullable restore
#line 110 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Unit_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90461e40cb1cb3d9e8082050093ab41c8fe59d3f17607", async() => {
                WriteLiteral("\r\n\r\n                                        <input type=\"hidden\" name=\"Game_number\"");
                BeginWriteAttribute("value", " value=\"", 5480, "\"", 5505, 1);
#nullable restore
#line 113 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
WriteAttributeValue("", 5488, item.Game_number, 5488, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <div>\r\n                                            <input placeholder=\"購買數量\" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 5641, "\"", 5649, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""width:100px"">
                                            <button type=""submit"" style=""border: none"" data-placement=""bottom"" data-toggle=""popover"" data-trigger=""hover"" title=""購物車"" data-content=""點擊圖片加入購物車"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90461e40cb1cb3d9e8082050093ab41c8fe59d3f18924", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90461e40cb1cb3d9e8082050093ab41c8fe59d3f21567", async() => {
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
#line 121 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
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
                                <h6>《大衍江湖》是一款武侠题材，结合经营养成，角色扮演的游戏。玩家将操控一个江湖门派；与江湖上的其他各色各样的门派打交道，或建立贸易或直接攻陷；与其他门派弟子交流，或结交或抢夺；江湖世界上各种随机事件，能获得具体好处同时也伴随着各种风险；门派传承，终有一日，将主宰江湖。</h6><br>
                                <h6>弟子招募</h6>
                                <h6>门派要生存自然少不了要招募弟子，招募的手段各式各样，可以通过门派发布消息，也可以派遣弟子到江湖四处寻找，甚至去掳掠关入监牢，强迫其加入；而且据说江湖上还有不少“人贩子”，有钱的话，说不定能买到资质不错的人哟。</h6><br>
                                <h6>功法系统</h6>
                                <h6>玩家门派弟子所学武技全由掌门自创而来，在门派设施“武楼”中，可以选择不同的招式与威力进行组合；如果有特殊能力的护法弟子，武技的威力还能得到额外提升！除了武技，内功、身法等基础功法也不能少，全靠玩家通过各种探索奇遇获得；积累优秀功法并修至圆满然后将其传承下去，门派将越来越强。</h6><br>
                                <h6>炼器炼药</h6>
                                <h6>玩家收集获取到各种类型的材料，可以为门下弟子打造各种装备，根据材料阴阳五行属性的合理搭配与优秀的炼制弟子，打造出的装备属性天差地别；炼制的丹药也会根据不同的药材，拥有不同的功效，是一瓶丹药拥有多种功效，还是专精一种功效，全靠玩家自己搭配。<");
            WriteLiteral(@"/h6><br>
                                <h6>江湖历练</h6>
                                <h6>门派中的亲传弟子可以被派遣到江湖世界进行历练，玩家需要控制历练弟子在江湖大地图上进行探索与形形色色的人接触；是功力大涨满载而归还是被人截杀于半路，江湖凶险，需要玩家自己选择。</h6><br>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
");
#nullable restore
#line 141 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Game_Story\Game_Story25.cshtml"
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
                                    <h6>記憶體: 8 GB 記憶體</h6>
                                    <h6>儲存空間: 1 GB 可用空間</h6>
                                </div>
                                <div class=""col-md-6 margin10px0"">
                             ");
            WriteLiteral(@"       <h6>建議配備: 需要 64 位元的處理器及作業系統</h6>
                                    <h6>記憶體: 8 GB 記憶體</h6>
                                    <h6>儲存空間: 1 GB 可用空間</h6>
                                </div>
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
            <div class=""col-md-10 offset-md-1"">
                <div class=""row container"">
                    <div class=""col-md-12 margin10px0"">
                        <h3 class=""text-warning"">精彩影片</h3>
                    </div>
                    <div class=""col-md-6"">
                        <p><iframe src=""https://www.youtube.com/embed/y8REs8s9awY"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe></p>
              ");
            WriteLiteral(@"      </div>
                    <div class=""col-md-6"">
                        <p><iframe src=""https://www.youtube.com/embed/Gz9ozC-nGFI"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe></p>
                    </div>
                    <div class=""col-md-6"">
                        <p><iframe src=""https://www.youtube.com/embed/M0MZK4AwAwY"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe></p>
                    </div>
                    <div class=""col-md-6"">
                        <p><iframe src=""https://www.youtube.com/embed/82VoZraHufo"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe></p>
                    </div>
                </div>
  ");
            WriteLiteral("          </div>\r\n        </div>\r\n    </div>\r\n</section>");
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