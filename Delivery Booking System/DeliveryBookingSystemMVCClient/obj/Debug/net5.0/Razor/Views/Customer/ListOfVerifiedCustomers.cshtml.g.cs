#pragma checksum "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77230a9127310a0c0d9a5668c6283879390581f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ListOfVerifiedCustomers), @"mvc.1.0.view", @"/Views/Customer/ListOfVerifiedCustomers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77230a9127310a0c0d9a5668c6283879390581f7", @"/Views/Customer/ListOfVerifiedCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8bdec0fe0af8d53154705e1b8be8b2cdb84b0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ListOfVerifiedCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeliveryBookingSystemMVCClient.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
  
    ViewData["Title"] = "ListOfVerifiedCustomers";
    Layout = "~/Views/Shared/AdminCustomerListLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>List Of Verified Customers</h3>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.PinCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.IsVerified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.PinCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsVerified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.ActionLink("Edit", "EditCustomerDetails", new { id = item.CustomerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                ");
#nullable restore
#line 77 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
           Write(Html.ActionLink("Delete", "DeleteCustomerDetails", new { id = item.CustomerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 80 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Customer\ListOfVerifiedCustomers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeliveryBookingSystemMVCClient.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
