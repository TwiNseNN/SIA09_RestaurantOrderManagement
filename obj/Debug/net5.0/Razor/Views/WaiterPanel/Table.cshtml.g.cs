#pragma checksum "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1063e59b4f193736242151716f66e4d8409572b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WaiterPanel_Table), @"mvc.1.0.view", @"/Views/WaiterPanel/Table.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1063e59b4f193736242151716f66e4d8409572b5", @"/Views/WaiterPanel/Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca2cdc863e1b4a10a9f234beb66d5d9ad0458c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_WaiterPanel_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrderItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkAsServed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToggleRevert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EndOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
  
    ViewData["Title"] = $"Table {Model.TableNumber}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Order for Table ");
#nullable restore
#line 9 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
               Write(Model.TableNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1063e59b4f193736242151716f66e4d8409572b55891", async() => {
                WriteLiteral("Add new Item");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
                                                            WriteLiteral(Model.TableNumber);

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
            WriteLiteral(@"

<table class=""table mb-3"">
    <thead>
        <tr>
            <th>Item Name</th>
            <th>Status</th>
            <th>Category</th>
            <th>Price</th>
            <th>Is Reverted</th>
            <th>Options</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
 foreach (var orderItem in Model.OrderItems)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("class", " class=\"", 702, "\"", 755, 1);
#nullable restore
#line 27 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
WriteAttributeValue("", 710, orderItem.IsReverted ? "table-danger" : "", 710, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
            Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("x\r\n                ");
#nullable restore
#line 30 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
           Write(orderItem.MenuItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 33 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
                   
                    var className = "";
                    switch (orderItem.Status)
                    {
                        case OrderItemStatus.NotReady:
                            className = "badge-danger"; break;
                        case OrderItemStatus.Preparing:
                            className = "badge-warning"; break;
                        case OrderItemStatus.ReadyToServe:
                            className = "badge-success"; break;
                        case OrderItemStatus.Served:
                            className = "badge-secondary"; break;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span");
            BeginWriteAttribute("class", " class=\"", 1579, "\"", 1605, 2);
            WriteAttributeValue("", 1587, "badge", 1587, 5, true);
#nullable restore
#line 47 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
WriteAttributeValue(" ", 1592, className, 1593, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 48 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
               Write(Enum.GetName(typeof(OrderItemStatus), orderItem.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
           Write(orderItem.MenuItem.PrettifiedCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
            Write(orderItem.MenuItem.Price * orderItem.Quantity / 100);

#line default
#line hidden
#nullable disable
            WriteLiteral(" lei\r\n            </td>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
            Write(orderItem.IsReverted ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 57 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
                 if (orderItem.Status == OrderItemStatus.ReadyToServe)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1063e59b4f193736242151716f66e4d8409572b512736", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2197, "\"", 2245, 3);
#nullable restore
#line 60 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
WriteAttributeValue("", 2205, orderItem.OrderId, 2205, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2223, "-", 2223, 1, true);
#nullable restore
#line 60 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
WriteAttributeValue("", 2224, orderItem.MenuItemId, 2224, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"returnToTable\"");
                BeginWriteAttribute("value", " value=\"", 2316, "\"", 2342, 1);
#nullable restore
#line 61 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
WriteAttributeValue("", 2324, Model.TableNumber, 2324, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-outline-success\">\r\n                            Serve\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1063e59b4f193736242151716f66e4d8409572b516054", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2660, "\"", 2708, 3);
#nullable restore
#line 68 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
WriteAttributeValue("", 2668, orderItem.OrderId, 2668, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2686, "-", 2686, 1, true);
#nullable restore
#line 68 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
WriteAttributeValue("", 2687, orderItem.MenuItemId, 2687, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"returnToTable\"");
                BeginWriteAttribute("value", " value=\"", 2775, "\"", 2801, 1);
#nullable restore
#line 69 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
WriteAttributeValue("", 2783, Model.TableNumber, 2783, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"btn btn-outline-danger btn-sm\">\r\n                        ");
#nullable restore
#line 71 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
                    Write(orderItem.IsReverted ? "Unrevert" : "Revert");

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 76 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"2\">Total</td>\r\n            <td>");
#nullable restore
#line 79 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
            Write(Model.Total / 100.0);

#line default
#line hidden
#nullable disable
            WriteLiteral(" lei</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 84 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
 if (Model.OrderItems.All(oi => oi.Status == OrderItemStatus.Served))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1063e59b4f193736242151716f66e4d8409572b520320", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"orderId\"");
                BeginWriteAttribute("value", " value=\"", 3364, "\"", 3386, 1);
#nullable restore
#line 87 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
WriteAttributeValue("", 3372, Model.OrderId, 3372, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <div class=""card"">
            <div class=""card-header"">
                <h5 class=""card-title"">Payment</h5>
            </div>
            <div class=""card-body"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""paymentMethod"" value=""Card"" id=""method_card"" />
                    <label class=""form-check-label"" for=""method_card"">Card 💳</label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""paymentMethod"" value=""Cash"" id=""method_cash"" />
                    <label class=""form-check-label"" for=""method_cash"">Cash 💵</label>
                </div>
            </div>
            <div class=""card-footer"">
                <button class=""btn btn-primary"">End order</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 107 "C:\Users\TwiNseNN\Documents\GitHub\SIA09_RestaurantOrderManagement\Views\WaiterPanel\Table.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
