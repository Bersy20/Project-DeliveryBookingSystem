#pragma checksum "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bccf36c37ab212579703511b9fa24bf7d82b5b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_ListOfBookingsByCustomer), @"mvc.1.0.view", @"/Views/Booking/ListOfBookingsByCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bccf36c37ab212579703511b9fa24bf7d82b5b8", @"/Views/Booking/ListOfBookingsByCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8bdec0fe0af8d53154705e1b8be8b2cdb84b0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_ListOfBookingsByCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeliveryBookingSystemMVCClient.Models.Booking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
  
    ViewData["Title"] = "ListOfBookingsByCustomer";
    Layout = "~/Views/Shared/CustomerLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>My Bookings</h3>\r\n\r\n<br />\r\n\r\n    <span class=\"badge badge-danger\">");
#nullable restore
#line 13 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
                                Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<br/>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.BookingId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.ExecutiveId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.DateTimeOfPickUp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.PinCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 55 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.BookingId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExecutiveId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateTimeOfPickUp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.PinCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.DisplayFor(modelItem => item.DeliveryStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 92 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.ActionLink("Edit", "EditBookingDetails", new { id = item.BookingId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 93 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
               Write(Html.ActionLink("Cancel Booking", "CancelBooking", new { id = item.BookingId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 96 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Booking\ListOfBookingsByCustomer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeliveryBookingSystemMVCClient.Models.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
