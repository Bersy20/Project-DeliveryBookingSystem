#pragma checksum "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41904594ec093938ed8e73a60c6c90387ac8f870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_ViewBookingDetails), @"mvc.1.0.view", @"/Views/Booking/ViewBookingDetails.cshtml")]
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
#line 1 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\_ViewImports.cshtml"
using DeliveryBookingSystemMVCClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\_ViewImports.cshtml"
using DeliveryBookingSystemMVCClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41904594ec093938ed8e73a60c6c90387ac8f870", @"/Views/Booking/ViewBookingDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8bdec0fe0af8d53154705e1b8be8b2cdb84b0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_ViewBookingDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryBookingSystemMVCClient.Models.Booking>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
  
    ViewData["Title"] = "ViewBookingDetails";
     Layout = "~/Views/Shared/CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>My Booking Details</h3>\r\n\r\n<div>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41904594ec093938ed8e73a60c6c90387ac8f8703998", async() => {
                WriteLiteral("\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 15 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.BookingId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 18 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.BookingId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 21 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 24 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 27 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.ExecutiveId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 30 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.ExecutiveId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 33 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.DateTimeOfPickUp));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 36 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.DateTimeOfPickUp));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 39 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 42 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 45 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 48 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 51 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 54 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 57 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.PinCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 60 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.PinCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 63 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 66 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 69 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n\r\n                ");
#nullable restore
#line 73 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 76 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 79 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
           Write(Html.DisplayFor(model => model.DeliveryStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <span class=\"badge badge-success\">");
#nullable restore
#line 83 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ViewBookingDetails.cshtml"
                                 Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryBookingSystemMVCClient.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
