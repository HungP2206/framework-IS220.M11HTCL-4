#pragma checksum "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76075ef5a33e94f076c26b1598186ad8fabb9780"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_viewdetailOrder), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/viewdetailOrder.cshtml")]
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
#line 1 "C:\web_bansach\web_bansach\Areas\Admin\Views\_ViewImports.cshtml"
using web_bansach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\web_bansach\web_bansach\Areas\Admin\Views\_ViewImports.cshtml"
using web_bansach.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76075ef5a33e94f076c26b1598186ad8fabb9780", @"/Areas/Admin/Views/Order/viewdetailOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622165dcd2f2f0fd1a40fb0a24c8750c40bbf48e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_viewdetailOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<object>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("searchOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 1000px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
    <div class=""section-block"" id=""basicform"">
        <h3 class=""section-title"">ĐƠN HÀNG</h3>
        <!-- <p>Use custom button styles for actions in forms, dialogs, and more with support for multiple sizes, states, and more.</p> -->
    </div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76075ef5a33e94f076c26b1598186ad8fabb97805355", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <input type=""text"" class=""form-control"" id=""email"" placeholder=""Tìm kiếm"" name=""searchString"" required />

        </div>
        <button type=""submit"" class=""btn btn-default"" style=""background-color: #ccc""><i class=""fa fa-search""></i></button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""cardall"">
        <div class=""ecommerce-widget"">
            <div class=""row"">
                <div class=""col-xl-12 col-lg-12 col-md-6 col-sm-12 col-12"">
                    <div class=""card"">
                        <div class=""card-body p-0"">
                            <div class=""table-responsive"">
                                <table class=""table border-1"">
                                    <thead class=""bg-light"">
                                        <tr class=""border-1"">
                                            <th class=""border-1"">ID</th>
                                            <th class=""border-1"">Tên KH</th>
                                            <th class=""border-1"">Địa chỉ nhận hàng</th>
                                            <th class=""border-1"">Tên sách</th>
                                            <th class=""border-1"">Đơn giá (chưa áp KM) (VNĐ)</th>
                                            <th class=""border-1"">Số lượng</th>
      ");
            WriteLiteral(@"                                      <th class=""border-1"">Khuyến mãi (%)</th>
                                            <th class=""border-0"">Đơn giá (đã áp KM) (VNĐ)</th>
                                            <th class=""border-0"">Tổng (VNĐ)</th>
                                            <th class=""border-0"">Thao tác </th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 40 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr class=\"border-1\">\r\n                                                <td class=\"border-1\"> ");
#nullable restore
#line 43 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                                                 Write(item.GetType().GetProperty("OrderID").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"border-1\"> ");
#nullable restore
#line 44 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                                                 Write(item.GetType().GetProperty("CustomerName").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"border-1\"> ");
#nullable restore
#line 45 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                                                 Write(item.GetType().GetProperty("Address").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"border-1\"> ");
#nullable restore
#line 46 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                                                 Write(item.GetType().GetProperty("BookName").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"border-1\"> ");
#nullable restore
#line 47 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                                                 Write(item.GetType().GetProperty("PriceUnit").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"border-1\"> ");
#nullable restore
#line 48 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                                                 Write(item.GetType().GetProperty("Quantity").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"border-1\"> ");
#nullable restore
#line 49 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                                                 Write(item.GetType().GetProperty("Sale").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                                                <td class=\"border-1\"> ");
#nullable restore
#line 50 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                                                 Write(item.GetType().GetProperty("PriceSale").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                                                <td class=\"border-1 item\"> ");
#nullable restore
#line 51 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                                                      Write(item.GetType().GetProperty("Totalbyquantity").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n\r\n                                                <td class=\"border-1\"> <a");
            BeginWriteAttribute("href", " href=\"", 3765, "\"", 3849, 2);
            WriteAttributeValue("", 3772, "detailOrderPDF?id=", 3772, 18, true);
#nullable restore
#line 53 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
WriteAttributeValue("", 3790, item.GetType().GetProperty("OrderID").GetValue(item, null), 3790, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xuất hoá đơn</a></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 55 "C:\web_bansach\web_bansach\Areas\Admin\Views\Order\viewdetailOrder.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                </table>


                            </div>
                            <div style=""font-weight:bold; font-size:20px"">
                                TỔNG HOÁ ĐƠN: <p id=""total"" style=""font-weight:bold; font-size:20px""> </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {

            var sum = 0;
            $("".item"").each(function () {

                sum += (parseFloat($(this).text()));
            });
            var total = sum.total
            $(""#total"").html(sum + "" VNĐ"");

        })

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<object>> Html { get; private set; }
    }
}
#pragma warning restore 1591
