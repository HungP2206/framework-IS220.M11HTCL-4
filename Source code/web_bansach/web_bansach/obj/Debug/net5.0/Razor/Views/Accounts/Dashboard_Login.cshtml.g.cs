#pragma checksum "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "812949ce6bb6dfc75f89d6d8edbaf60a572f2867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Dashboard_Login), @"mvc.1.0.view", @"/Views/Accounts/Dashboard_Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"812949ce6bb6dfc75f89d6d8edbaf60a572f2867", @"/Views/Accounts/Dashboard_Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622165dcd2f2f0fd1a40fb0a24c8750c40bbf48e", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Dashboard_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<web_bansach.Areas.Admin.Models.CustomerModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Thông tin tài khoản</h2>\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayNameFor(model => model.Created_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayFor(model => model.Created_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 48 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
            if(@Model.CustomerStatus.ToString() == "0")
           {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Còn hoạt động</p>");
#nullable restore
#line 49 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
                                 }
           
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Ngừng hoạt động</p>");
#nullable restore
#line 51 "C:\web_bansach\web_bansach\web_bansach\Views\Accounts\Dashboard_Login.cshtml"
                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n    \r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "812949ce6bb6dfc75f89d6d8edbaf60a572f28678244", async() => {
                WriteLiteral("Về trang chủ");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<web_bansach.Areas.Admin.Models.CustomerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
