#pragma checksum "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\AjaxSearchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24ec5e192381c20b39a2d4d662db742291b1e052"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizzas_AjaxSearchList), @"mvc.1.0.view", @"/Views/Pizzas/AjaxSearchList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizzas/AjaxSearchList.cshtml", typeof(AspNetCore.Views_Pizzas_AjaxSearchList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24ec5e192381c20b39a2d4d662db742291b1e052", @"/Views/Pizzas/AjaxSearchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfbf9d70e8ac09fbc236502c2f316b2c1a1e86e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizzas_AjaxSearchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pizzas>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 27, true);
            WriteLiteral("\r\n<h4>Search Results</h4>\r\n");
            EndContext();
#line 4 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\AjaxSearchList.cshtml"
 foreach (var pizza in Model)
{
    

#line default
#line hidden
            BeginContext(87, 35, false);
#line 6 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\AjaxSearchList.cshtml"
Write(Html.Partial("PizzaSummary", pizza));

#line default
#line hidden
            EndContext();
#line 6 "C:\Users\vikto\source\repos\OnlinePizzaWebApplication\OnlinePizzaWebApplication\Views\Pizzas\AjaxSearchList.cshtml"
                                        
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pizzas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
