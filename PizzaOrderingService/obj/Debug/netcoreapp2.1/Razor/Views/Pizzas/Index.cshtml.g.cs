#pragma checksum "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "907598e114541047095ee6eb9406a0f63c887822"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizzas_Index), @"mvc.1.0.view", @"/Views/Pizzas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizzas/Index.cshtml", typeof(AspNetCore.Views_Pizzas_Index))]
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
#line 1 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\_ViewImports.cshtml"
using PizzaOrderingService.Models;

#line default
#line hidden
#line 2 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\_ViewImports.cshtml"
using PizzaOrderingService.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907598e114541047095ee6eb9406a0f63c887822", @"/Views/Pizzas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfbf9d70e8ac09fbc236502c2f316b2c1a1e86e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizzas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pizzas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
  
    var pageName = "Pizzas";
    ViewData["Title"] = pageName;

#line default
#line hidden
            BeginContext(96, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(102, 8, false);
#line 8 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
Write(pageName);

#line default
#line hidden
            EndContext();
            BeginContext(110, 15, true);
            WriteLiteral("</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(125, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a764a2bc19fb4e00ad93ddf8d9d8f39d", async() => {
                BeginContext(163, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(177, 94, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n                <th>\n                    ");
            EndContext();
            BeginContext(272, 40, false);
#line 17 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(312, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(377, 41, false);
#line 20 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(418, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(483, 47, false);
#line 23 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(530, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(595, 44, false);
#line 26 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(639, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(704, 52, false);
#line 29 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IsPizzaOfTheWeek));

#line default
#line hidden
            EndContext();
            BeginContext(756, 56, true);
            WriteLiteral("\n                </th>\n            <th>\n                ");
            EndContext();
            BeginContext(813, 44, false);
#line 32 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(857, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 38 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(968, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1015, 39, false);
#line 41 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1107, 40, false);
#line 44 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1200, 46, false);
#line 47 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1299, 43, false);
#line 50 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1395, 51, false);
#line 53 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsPizzaOfTheWeek));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1499, 48, false);
#line 56 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1599, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "278a8eaa498e4103b4f173a9f21e19eb", async() => {
                BeginContext(1644, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
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
            BeginContext(1652, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1671, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc76676f190f46e5aaecbd0d39c81229", async() => {
                BeginContext(1719, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
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
            BeginContext(1730, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1749, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5e72c9ff11b40d0a4fb999def850f6a", async() => {
                BeginContext(1796, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
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
            BeginContext(1806, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 64 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1841, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pizzas>> Html { get; private set; }
    }
}
#pragma warning restore 1591