#pragma checksum "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa112a7d544178a519b8b34b16519653e9dba075"
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
#line 1 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\_ViewImports.cshtml"
using WebMyPham.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\_ViewImports.cshtml"
using WebMyPham.AdminApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
using WebMyPham.ViewModels.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa112a7d544178a519b8b34b16519653e9dba075", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4097d376872ac7d114919947daffa5438fd0ea91", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<WebMyPham.ViewModels.Catalog.Orders.OrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dropbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Danh sách đơn hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        setTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách đơn hàng</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách đơn hàng</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-6 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa112a7d544178a519b8b34b16519653e9dba0756325", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-4\">\r\n                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 974, "\"", 998, 1);
#nullable restore
#line 30 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
WriteAttributeValue("", 982, ViewBag.Keyword, 982, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"keyword\" class=\"form-control\" />\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 40 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                 if (ViewBag.SuccessMsg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                        ");
#nullable restore
#line 43 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                   Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 45 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr class=""table-info text-bold"">
                            <th>
                                Mã
                            </th>
                            <th>
                                Người đặt
                            </th>
                            <th>
                                Địa chỉ
                            </th>
                            <th>
                                Số điện thoại
                            </th>
                            <th>
                                Tổng tiền
                            </th>
                            <th>
                                Trạng thái
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 72 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 76 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 79 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ShipName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 82 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 85 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ShipPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 88 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => (item.Price * item.Quantity)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 90 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                             if (item.Status == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"font-style:italic;color:slategrey\">\r\n                                    Đã xác nhận\r\n                                </td>\r\n");
#nullable restore
#line 95 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                            }
                            else if (item.Status == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"font-style:italic;color:slategrey\">\r\n                                    Thành công\r\n                                </td>\r\n");
#nullable restore
#line 101 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                            }
                            else if (item.Status == 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"font-style:italic;color:slategrey\">\r\n                                    Đã hủy\r\n                                </td>\r\n");
#nullable restore
#line 107 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa112a7d544178a519b8b34b16519653e9dba07515807", async() => {
                WriteLiteral("Duyệt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 113 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 115 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            ");
#nullable restore
#line 119 "C:\Users\Han Tran\Documents\Testing TLCN\Final Project\WebMyPham_test-20201229T134247Z-001\WebMyPham_test\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Index.cshtml"
       Write(await Component.InvokeAsync("Pager", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<WebMyPham.ViewModels.Catalog.Orders.OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591