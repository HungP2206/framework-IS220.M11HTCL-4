#pragma checksum "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13a9b9d50b9e8acb5521d3816a5a7475f3c1a800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_detailBook), @"mvc.1.0.view", @"/Views/Home/detailBook.cshtml")]
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
#line 1 "C:\web_bansach\web_bansach\web_bansach\Views\_ViewImports.cshtml"
using web_bansach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\web_bansach\web_bansach\web_bansach\Views\_ViewImports.cshtml"
using web_bansach.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a9b9d50b9e8acb5521d3816a5a7475f3c1a800", @"/Views/Home/detailBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622165dcd2f2f0fd1a40fb0a24c8750c40bbf48e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_detailBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<object>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div class=\"breadcrumbs position-relative pl-4 pr-4 pt-4 pb-4 lazy_bg loaded\">\r\n            <div class=\"inner position-relative text-center\">\r\n                <h1 class=\"cat-heading d-none d-md-block\">");
#nullable restore
#line 15 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                                     Write(item.GetType().GetProperty("BookName").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <div>
        <div class=""container"">
            <div class=""row clearfix border"" style=""position: relative"">
                <div class=""col-xl-9 col-lg-9 col-12 pt-4"">
                    <div class=""row clearfix"">
                        <div class=""product-layout_col-left col-12 col-sm-12 col-md-5 col-lg-5 col-xl-6 mb-3 border"">

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13a9b9d50b9e8acb5521d3816a5a7475f3c1a8006115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1188, "~/images/", 1188, 9, true);
#nullable restore
#line 31 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
AddHtmlAttributeValue("", 1197, item.GetType().GetProperty("Img").GetValue(item, null), 1197, 55, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"product-layout_col-right col-12 col-sm-12 col-md-7 col-lg-7 col-xl-6 product-warp border\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13a9b9d50b9e8acb5521d3816a5a7475f3c1a8007911", async() => {
                WriteLiteral("\r\n\r\n                                <h3 class=\"product-name font-weight-bold text-uppercase\" name=\"bookname\"");
                BeginWriteAttribute("value", " value=\"", 1642, "\"", 1650, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 38 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                                                                                             Write(item.GetType().GetProperty("BookName").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                <div class=\"product-info position-relative\">\r\n                                    Tình trạng:\r\n");
#nullable restore
#line 41 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                     if (@item.GetType().GetProperty("Quantity").GetValue(item, null).ToString() == "0")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span class=\"inventory_quantity text-danger\">Hết hàng</span>\r\n");
#nullable restore
#line 44 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                    }

                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span class=\"inventory_quantity\">Còn hàng</span>");
#nullable restore
#line 47 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                                                                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                </div>\r\n");
                WriteLiteral("                                <input id=\"BookID\" name=\"BookID\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2464, "\"", 2530, 1);
#nullable restore
#line 52 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
WriteAttributeValue("", 2472, item.GetType().GetProperty("BookID").GetValue(item, null), 2472, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input name=\"BookName\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2604, "\"", 2672, 1);
#nullable restore
#line 53 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
WriteAttributeValue("", 2612, item.GetType().GetProperty("BookName").GetValue(item, null), 2612, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input name=\"PriceUnit\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2745, "\"", 2814, 1);
#nullable restore
#line 54 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
WriteAttributeValue("", 2753, item.GetType().GetProperty("PriceUnit").GetValue(item, null), 2753, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input name=\"Sale\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2882, "\"", 2946, 1);
#nullable restore
#line 55 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
WriteAttributeValue("", 2890, item.GetType().GetProperty("Sale").GetValue(item, null), 2890, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input name=\"Img\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3013, "\"", 3076, 1);
#nullable restore
#line 56 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
WriteAttributeValue("", 3021, item.GetType().GetProperty("Img").GetValue(item, null), 3021, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("\r\n                                <div class=\"product-info position-relative\">\r\n                                    Tác giả: <span id=\"vendor\">");
#nullable restore
#line 60 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                                          Write(item.GetType().GetProperty("AuthorName").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"product-info position-relative mb-3\">Loại: <span id=\"type\"></span>");
#nullable restore
#line 62 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                                                                                         Write(item.GetType().GetProperty("CategoryName").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                <div class=\"product-summary border-top pt-3 mt-2 pb-3\">\r\n                                    <p>");
#nullable restore
#line 64 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                  Write(item.GetType().GetProperty("Introduction").GetValue(item, null).ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                    <a class=""d-block js-learn-more-link"" href=""#detail"">[Xem chi tiết]</a>
                                </div>
                                <div class=""product-price font-weight-bold"">
                                    <span class=""special-price m-0"">");
#nullable restore
#line 68 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                                               Write(item.GetType().GetProperty("Total").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</span>\r\n                                    <del class=\"old-price ml-2\">");
#nullable restore
#line 69 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                                           Write(item.GetType().GetProperty("PriceUnit").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" đ</del>
                                </div>

                                <div class=""product-quantity d-sm-flex align-items-center clearfix"">
                                    <header class=""font-weight-bold mb-2"" style=""min-width: 100px;"">Số lượng:</header>
                                    <div class=""custom-btn-number border-0 d-flex"">
                                        <button class=""border rounded bg-white""
                                                onclick=""var result = document.getElementById('NewQuantity'); var qtypro = result.value; if( !isNaN( qtypro ) && qtypro > 1 ) result.value--;return false;"" type=""button"">
                                            -
                                        </button>
                                        <input type=""number"" style=""text-align:center"" maxlength=""2"" name=""Quantity"" min=""1"" value=""1"" class=""form-control prd_quantity border rounded"" id=""NewQuantity"">
                                        <button class=""border r");
                WriteLiteral(@"ounded bg-white"" onclick=""var result = document.getElementById('NewQuantity');
                                            var qtypro = result.value; if (!isNaN(qtypro)) result.value++; return false;"" type=""button"">
                                            +
                                        </button>
                                    </div>
                                </div>
                                <div class=""col-12 pt-2 pb-2"">
                                    <button type=""submit""
                                            class=""add-to-cart btn d-flex w-100 justify-content-center flex-row align-items-center rounded pt-2 pb-2 product-action_buy js-addToCart sitdown modal-open text-uppercase font-weight-bold"">
                                        Mua ngay
                                    </button>
");
                WriteLiteral("                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>

                        <div id=""detail"" class=""product-content border-top pt-4 mewcontent"">
                            <h3 class=""special-content_title font-weight-bold"">Thông tin chi tiết</h3>
                            <div class="" position-relative rte"">
                                <p><strong>");
#nullable restore
#line 99 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                                      Write(item.GetType().GetProperty("BookName").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                <p>\r\n                                    <br>\r\n                                    ");
#nullable restore
#line 102 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
                               Write(item.GetType().GetProperty("Description").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-lg-3 col-12 border mt-4"">
                    <div class=""row align-items-center msb mb-4 d-lg-block olp"">
                        <div class=""item_coupon col-12 col-sm-6 col-md-6 col-lg-12 col-xl-12 mb-2"">
                            <div class=""content o_1 text-center p-xl-2 p-lg-2 p-sm-3 p-2 my-1 d-flex flex-column align-items-center position-relative"">
                                <h4 class=""coupon-title mt-2 mb-2 text-capitalize line_1"">MewBS100</h4>
                                <p class=""desc""><b>Giảm ngay 100K</b> - Mã áp dụng cuối tuần thứ 7, CN</p>
                            </div>

                            <div class=""content o_2 text-center p-xl-2 p-lg-2 p-sm-3 p-2 my-1 d-flex flex-column align-items-center position-relative"">
                                <h4 class=""coupon-titl");
            WriteLiteral(@"e mt-2 mb-2 text-capitalize line_1"">MewBS100</h4>
                                <p class=""desc""><b>Giảm ngay 100K</b> - Mã áp dụng cuối tuần thứ 7, CN</p>
                            </div>

                            <div class=""content o_3 text-center p-xl-2 p-lg-2 p-sm-3 p-2 my-1 d-flex flex-column align-items-center position-relative"">
                                <h4 class=""coupon-title mt-2 mb-2 text-capitalize line_1"">MewBS100</h4>
                                <p class=""desc""><b>Giảm ngay 100K</b> - Mã áp dụng cuối tuần thứ 7, CN</p>
                            </div>
                            <div class=""content o_4 text-center p-xl-2 p-lg-2 p-sm-3 p-2 my-1 d-flex flex-column align-items-center position-relative"">
                                <h4 class=""coupon-title mt-2 mb-2 text-capitalize line_1"">MewBS100</h4>
                                <p class=""desc""><b>Giảm ngay 100K</b> - Mã áp dụng cuối tuần thứ 7, CN</p>
                            </div>
                       ");
            WriteLiteral(" </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <!--<div class=""m_product col-12 mt-5 mb-5 border"">
        <h2 class=""title mb-4 mt-3 text-uppercase font-weight-bold text-center position-relative"">
            <a class=""position-relative"" href=""san-pham-noi-bat"" title=""Sản phẩm khác"">Sản phẩm khác</a>
        </h2>

        <div>
            <div class=""slideshow-container border"">
                <div class=""mySlides p-2"" style=""display: block;"">
                    <div class=""slide-container"">
                    
                    </div>
                </div>
                <div class=""mySlides p-2"" style=""display: block;"">
                    <div class=""slide-container"">-->
");
            WriteLiteral(@"                        <!--<div class=""border zoom p-3 m-1 d-inline-flex position-relative modal-open border"">
                            <div class=""display_detail_image""><a href=""{{URL::to('/chi-tiet-san-pham/'.$relates->BookID)}}""><img src=""{{asset('./../public/frontend/image/'.$relates->Img)}}"" class=""img-fluid mb-2"" style=""width: 223px"" alt=""""></a></div>
                            <div class=""item-info-home position-absolute text-center "">
                                <h6 class=""pt-1 modal-open d-block pb-0 mb-0"" style=""display: -webkit-box;"">{{$relates->BookName}}</h6>
                                <div class=""product-price-slibar"">
                                    <span class=""special-price font-weight-bold"">{{$relates->PriceSale}}₫</span>
                                    <del class=""old-price"">{{$relates->PriceUnit}}₫</del>
                                </div>
                                <button class=""btn action font-weight-bold d-inline-block position-relative mt-1 mb-2"">");
            WriteLiteral(@"<a href=""{{URL::to('/chi-tiet-san-pham/'.$relates->BookID)}}"">Chi tiết</a></button>
                            </div>
                        </div>
                    
                    </div>
                </div>

                <a class=""prev"" onclick=""plusSlides(-1)"">&#10094;</a>
                <a class=""next"" onclick=""plusSlides(1)"">&#10095;</a>
            </div>
            <br>

            <div style=""text-align:center"">
                <span class=""dot"" onclick=""currentSlide(1)""></span>
                <span class=""dot"" onclick=""currentSlide(2)""></span>
                <span class=""dot"" onclick=""currentSlide(3)""></span>
            </div>
        </div>
    </div>-->
");
            WriteLiteral("    <script type=\"text/javascript\" src=\"{{asset(\'./../public/frontend/js/script.js\')}}\"></script>\r\n");
#nullable restore
#line 181 "C:\web_bansach\web_bansach\web_bansach\Views\Home\detailBook.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(function () {
                $("".add-to-cart"").click(function () {
                    var BookID = $('#BookID').val();
                    var NewQuantity = $('#NewQuantity').val();
                    $.ajax({
                        url: 'api/cart/add',
                        type: ""POST"",
                        dataType: ""JSON"",
                        data: {
                            BookID: BookID,
                            Quantity = NewQuantity,
                        },
                        success: function (response) {
                            //loadHearCart();
                            location.reload();
                        },
                        error: function (error) {
                            alert(error.responseText);
                        }
                    })
                })
            })
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<object>> Html { get; private set; }
    }
}
#pragma warning restore 1591
