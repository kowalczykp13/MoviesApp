#pragma checksum "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "546115eb39f73949f59ad2a3608f4ec8b84a4a49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"546115eb39f73949f59ad2a3608f4ec8b84a4a49", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1839aec3c9e26996da80634f1eca7ae06d604143", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "List of all users";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6 offset-3\">\r\n        <p>\r\n            <h4>List of all users</h4>\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n\r\n                    <th>");
#nullable restore
#line 15 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 16 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 17 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 23 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 27 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 30 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 33 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Account\Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
