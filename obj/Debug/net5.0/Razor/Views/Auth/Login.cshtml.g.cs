#pragma checksum "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\Auth\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f2d28635c6cd6ec3ea87c37f0b7923e56283724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Login), @"mvc.1.0.view", @"/Views/Auth/Login.cshtml")]
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
#line 1 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\_ViewImports.cshtml"
using RestaurantManagementOrder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\_ViewImports.cshtml"
using RestaurantManagementOrder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2d28635c6cd6ec3ea87c37f0b7923e56283724", @"/Views/Auth/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca2cdc863e1b4a10a9f234beb66d5d9ad0458c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantManagementOrder.Models.Auth.Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\Auth\Login.cshtml"
  
    ViewData["Title"] = "Hello world!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\Auth\Login.cshtml"
 if (ViewData.ContainsKey("error")) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        ");
#nullable restore
#line 11 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\Auth\Login.cshtml"
   Write(ViewData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\Auth\Login.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n");
#nullable restore
#line 16 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\Auth\Login.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <label>Email:</label>\r\n        ");
#nullable restore
#line 20 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\Auth\Login.cshtml"
   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Password:</label>\r\n        ");
#nullable restore
#line 24 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\Auth\Login.cshtml"
   Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control", @type="password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary btn-lg\">Submit!</button>\r\n");
#nullable restore
#line 27 "C:\Users\TwiNseNN\source\repos\RestaurantManagementOrder\Views\Auth\Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantManagementOrder.Models.Auth.Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
