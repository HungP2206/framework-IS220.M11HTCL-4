#pragma checksum "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\deleteCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51be7994dcbc159571db17dd683acfe0f6fc6928"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customer_deleteCustomer), @"mvc.1.0.view", @"/Areas/Admin/Views/Customer/deleteCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51be7994dcbc159571db17dd683acfe0f6fc6928", @"/Areas/Admin/Views/Customer/deleteCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622165dcd2f2f0fd1a40fb0a24c8750c40bbf48e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Customer_deleteCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\deleteCustomer.cshtml"
 if (@ViewData["kq"].ToString() == "1")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>alert(\"Xóa khách hàng thành công\"); window.location.href = \'");
#nullable restore
#line 4 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\deleteCustomer.cshtml"
                                                                   Write(Url.Content("allCustomer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';</script>\r\n");
#nullable restore
#line 5 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\deleteCustomer.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>alert(\"Xóa khách hàng thất bại\");window.location.href = \'");
#nullable restore
#line 9 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\deleteCustomer.cshtml"
                                                                Write(Url.Content("allCustomer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';</script>\r\n");
#nullable restore
#line 10 "C:\web_bansach\web_bansach\Areas\Admin\Views\Customer\deleteCustomer.cshtml"

}

#line default
#line hidden
#nullable disable
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
