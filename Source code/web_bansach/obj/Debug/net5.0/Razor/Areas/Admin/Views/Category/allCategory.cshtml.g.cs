#pragma checksum "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d38c2428348d901234dea61f469d2c22891f60a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_allCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/allCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d38c2428348d901234dea61f469d2c22891f60a8", @"/Areas/Admin/Views/Category/allCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622165dcd2f2f0fd1a40fb0a24c8750c40bbf48e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_allCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("searchCategorycontroller"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
    <div class=""section-block"" id=""basicform"">
        <h3 class=""section-title"">THỂ LOẠI SÁCH</h3>
        <!-- <p>Use custom button styles for actions in forms, dialogs, and more with support for multiple sizes, states, and more.</p> -->
    </div>
    <div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d38c2428348d901234dea61f469d2c22891f60a85341", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <input type=""text"" class=""form-control"" id=""email"" placeholder=""Search..."" name=""searchString"" required>
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
    </div>
    <div class=""cardall"">
        <div class=""ecommerce-widget"">
            <div class=""row"">
                <div class=""col-xl-12 col-lg-12 col-md-6 col-sm-12 col-12"">
                    <div class=""card"">
                        <div class=""card-body p-0"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead class=""bg-light"">
                                        <tr class=""border-0"">
                                            <th class=""border-0"">ID</th>
                                            <th class=""border-0"">Tên thể loại</th>
");
            WriteLiteral(@"                                            <th class=""border-0"">Ngày tạo</th>
                                            <th class=""border-0"">Trạng thái</th>
                                            <th class=""border-0"">Thao tác</th>
                                        </tr>
                                    </thead>

                                    <tbody>
");
#nullable restore
#line 35 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 38 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
                                               Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 39 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
                                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                                <td>");
#nullable restore
#line 41 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
                                               Write(item.Created_at.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n");
#nullable restore
#line 43 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
                                                     if (@item.CategoryStatus == 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"badge-dot badge-success mr-1\"></span> <p>Đang kinh doanh</p>\r\n");
#nullable restore
#line 46 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
                                                    }

                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"badge-dot badge-brand mr-1\"></span> <p>Ngừng kinh doanh</p>\r\n");
#nullable restore
#line 51 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                                <td>\r\n                                                    <a onclick=\"return confirm(\'Bạn có chắc muốn xóa danh mục này ?\')\"");
            BeginWriteAttribute("href", " href=\"", 3327, "\"", 3368, 2);
            WriteAttributeValue("", 3334, "deleteCategory?id=", 3334, 18, true);
#nullable restore
#line 54 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
WriteAttributeValue("", 3352, item.CategoryID, 3352, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-light\">Xóa</a>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3463, "\"", 3508, 2);
            WriteAttributeValue("", 3470, "viewupdateCategory?id=", 3470, 22, true);
#nullable restore
#line 55 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
WriteAttributeValue("", 3492, item.CategoryID, 3492, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-light\">Sửa</a>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 58 "C:\web_bansach\web_bansach\Areas\Admin\Views\Category\allCategory.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
