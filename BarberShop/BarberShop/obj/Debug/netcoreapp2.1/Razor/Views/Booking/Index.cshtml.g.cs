#pragma checksum "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "546f18e99d724bc23da19dc2da8af7e90b7c58e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Index.cshtml", typeof(AspNetCore.Views_Booking_Index))]
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
#line 1 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\_ViewImports.cshtml"
using BarberShop;

#line default
#line hidden
#line 2 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\_ViewImports.cshtml"
using BarberShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"546f18e99d724bc23da19dc2da8af7e90b7c58e2", @"/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a21745dcec023360e9920da4e983e54262df3fe3", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 341, true);
            WriteLiteral(@"
<h1>Available Bookings</h1>
<br />
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Barber</th>
            <th scope=""col"">Time</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\Booking\Index.cshtml"
          
            int i = 0;
        

#line default
#line hidden
            BeginContext(417, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\Booking\Index.cshtml"
         foreach (var item in Model)
        {
            ++i;

#line default
#line hidden
            BeginContext(486, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(537, 1, false);
#line 24 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\Booking\Index.cshtml"
                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(538, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(566, 16, false);
#line 25 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\Booking\Index.cshtml"
               Write(item.Barber.Name);

#line default
#line hidden
            EndContext();
            BeginContext(582, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(610, 29, false);
#line 26 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\Booking\Index.cshtml"
               Write(item.AvailableTime.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(639, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(667, 29, false);
#line 27 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\Booking\Index.cshtml"
               Write(item.BookingStatus.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(696, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(723, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32f09feba3474192b4b0e454272c7248", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\Booking\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(798, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Vartotojas\Desktop\KITM\NET\c-works\BarberShop\BarberShop\Views\Booking\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(835, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
