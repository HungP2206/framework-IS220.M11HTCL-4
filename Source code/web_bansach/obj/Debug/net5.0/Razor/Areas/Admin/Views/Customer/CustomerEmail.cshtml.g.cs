#pragma checksum "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\CustomerEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24e350fc54f0a99f81f99616664e0a222065b37a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customer_CustomerEmail), @"mvc.1.0.view", @"/Areas/Admin/Views/Customer/CustomerEmail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24e350fc54f0a99f81f99616664e0a222065b37a", @"/Areas/Admin/Views/Customer/CustomerEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622165dcd2f2f0fd1a40fb0a24c8750c40bbf48e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Customer_CustomerEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<web_bansach.Areas.Admin.Models.MailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\CustomerEmail.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 style=\"color:green\" >");
#nullable restore
#line 8 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\CustomerEmail.cshtml"
                    Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<div class=""row"">
    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
        <div class=""section-block"" id=""basicform"">
            <h3 class=""section-title"">Mail thông báo</h3>
            <!-- <p>Use custom button styles for actions in forms, dialogs, and more with support for multiple sizes, states, and more.</p> -->
        </div>
        <div class=""card"">
            <div class=""card-body"">
");
#nullable restore
#line 17 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\CustomerEmail.cshtml"
                 using (Html.BeginForm("CustomerEmail", "Customer", FormMethod.Post, new { enctype = "mutipart/form-data" }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        <label for=\"inputText3\" class=\"col-form-label\">Title</label><br />\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 22 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\CustomerEmail.cshtml"
                   Write(Html.TextBoxFor(model => model.Subject, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"inputText3\" class=\"col-form-label\">Description</label><br />\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 27 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\CustomerEmail.cshtml"
                   Write(Html.TextAreaFor(model => model.Body, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12 \">\r\n                        <button class=\"btn btn-primary\" type=\"submit\">Gửi</button>\r\n                    </div>\r\n");
#nullable restore
#line 32 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\CustomerEmail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<web_bansach.Areas.Admin.Models.MailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
