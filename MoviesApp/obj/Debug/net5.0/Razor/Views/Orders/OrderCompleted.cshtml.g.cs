#pragma checksum "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\OrderCompleted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17dd6ec126288c607616202c5833983a2680556d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_OrderCompleted), @"mvc.1.0.view", @"/Views/Orders/OrderCompleted.cshtml")]
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
#line 1 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using MoviesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using MoviesApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17dd6ec126288c607616202c5833983a2680556d", @"/Views/Orders/OrderCompleted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1839aec3c9e26996da80634f1eca7ae06d604143", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_OrderCompleted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6 offset-3 alert alert-success text-center"">
        <h2>Order compelet succesfully</h2>
        <p>You can check all your orders in the Orders section of your profiles</p>
        <hr/>
        <p> Thank you!</p>
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
