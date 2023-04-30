#pragma checksum "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abab18669381ae67c4883ac2039ea6b0388274bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CookPanel_Index), @"mvc.1.0.view", @"/Views/CookPanel/Index.cshtml")]
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
#line 1 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\_ViewImports.cshtml"
using RestaurantManagementOrder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\_ViewImports.cshtml"
using RestaurantManagementOrder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abab18669381ae67c4883ac2039ea6b0388274bb", @"/Views/CookPanel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca2cdc863e1b4a10a9f234beb66d5d9ad0458c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CookPanel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
  
    ViewData["Title"] = "Cook list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cook list</h1>\r\n");
#nullable restore
#line 7 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
 foreach (var orderItem in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 138, "\"", 209, 3);
            WriteAttributeValue("", 146, "card", 146, 4, true);
            WriteAttributeValue(" ", 150, "mb-2", 151, 5, true);
#nullable restore
#line 9 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
WriteAttributeValue(" ", 155, orderItem.IsReverted ? "text-white bg-danger" : "", 156, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card-header\">\r\n            Table ");
#nullable restore
#line 11 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
             Write(orderItem.Order.TableNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span");
            BeginWriteAttribute("class", " class=\"", 313, "\"", 415, 4);
            WriteAttributeValue("", 321, "badge", 321, 5, true);
            WriteAttributeValue(" ", 326, "float-right", 327, 12, true);
            WriteAttributeValue(" ", 338, "badge-", 339, 7, true);
#nullable restore
#line 12 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
WriteAttributeValue("", 345, orderItem.Status == OrderItemStatus.NotReady ? "danger" : "warning", 345, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 13 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
           Write(Enum.GetName(typeof(OrderItemStatus), orderItem.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            ");
#nullable restore
#line 17 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
        Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("x\r\n            ");
#nullable restore
#line 18 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
        Write(orderItem.MenuItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"float-right\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abab18669381ae67c4883ac2039ea6b0388274bb6952", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"compoundId\"");
                BeginWriteAttribute("value", " value=\"", 797, "\"", 845, 3);
#nullable restore
#line 21 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
WriteAttributeValue("", 805, orderItem.OrderId, 805, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 823, "-", 823, 1, true);
#nullable restore
#line 21 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
WriteAttributeValue("", 824, orderItem.MenuItemId, 824, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"newStatus\"");
                BeginWriteAttribute("value", " value=\"", 908, "\"", 994, 1);
#nullable restore
#line 22 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
WriteAttributeValue("", 916, orderItem.Status == OrderItemStatus.NotReady ? "Preparing" : "ReadyToServe", 916, 78, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button");
                BeginWriteAttribute("class", " class=\"", 1027, "\"", 1122, 3);
                WriteAttributeValue("", 1035, "btn", 1035, 3, true);
                WriteAttributeValue(" ", 1038, "btn-outline-", 1039, 13, true);
#nullable restore
#line 23 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
WriteAttributeValue("", 1051, orderItem.Status == OrderItemStatus.NotReady ? "primary" : "success", 1051, 71, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 24 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
                    Write(orderItem.Status == OrderItemStatus.NotReady ? "Take item" : "Mark as completed");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </button>\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\CookPanel\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            setTimeout(function () {\r\n                window.location = window.location;\r\n            }, 2500);\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
