#pragma checksum "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Executive\ExecutivePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c23a1b4ebb2268b274e7023b27afa08244912e9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Executive_ExecutivePage), @"mvc.1.0.view", @"/Views/Executive/ExecutivePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a1b4ebb2268b274e7023b27afa08244912e9a", @"/Views/Executive/ExecutivePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8bdec0fe0af8d53154705e1b8be8b2cdb84b0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Executive_ExecutivePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/Front.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Executive\ExecutivePage.cshtml"
  
    ViewData["Title"] = "ExecutivePage";
    Layout = "~/Views/Shared/ExecutiveLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h1>Hii ");
#nullable restore
#line 7 "D:\SOFTURA\Technical Training\Project-Delivery Booking System\Delivery Booking System\DeliveryBookingSystemMVCClient\Views\Executive\ExecutivePage.cshtml"
       Write(TempData.Peek("ExecutiveName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <br />
    <h2>Welcome to Our Delivery Booking Service !!!</h2>
    <br />
    <h4>ABOUT US</h4>
    <p>Since its inception in 2011, Delhivery has become India’s leading supply chain services company. Our vision is to become the operating system for commerce in India, through a combination of world-class infrastructure, logistics operations of the highest quality and cutting-edge engineering and technology capabilities.</p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c23a1b4ebb2268b274e7023b27afa08244912e9a5605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <br />
    <br />

    <h4>ITʼS IN THE GETTING THERE</h4>
    <p>
        Our team has successfully fulfilled over 1 billion orders to more than 300 million households across India. 24 automated sort centers, 85+ fulfilment centers, 75+ hubs, 3000+ direct delivery centers, 7500+ partner centers, 15000+ vehicles and 40000+ team members make it possible to deliver a million packages a day, 24 hours a day, 7 days a week, 365 days a year. We are De
    </p>
</div>
    
");
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
