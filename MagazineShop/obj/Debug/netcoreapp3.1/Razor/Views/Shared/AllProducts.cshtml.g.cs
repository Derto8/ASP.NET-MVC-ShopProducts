#pragma checksum "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "677987fec11aec66a85599e387944abd521a8ff0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllProducts), @"mvc.1.0.view", @"/Views/Shared/AllProducts.cshtml")]
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
#line 1 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\_ViewImports.cshtml"
using MagazineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\_ViewImports.cshtml"
using MagazineShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\_ViewImports.cshtml"
using MagazineShop.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\_ViewImports.cshtml"
using MagazineShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"677987fec11aec66a85599e387944abd521a8ff0", @"/Views/Shared/AllProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6059b56843c1e8138c95761245aa5ed1700fe4f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_AllProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg-4\">\r\n    <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 72, "\"", 88, 1);
#nullable restore
#line 4 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
WriteAttributeValue("", 78, Model.Img, 78, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 89, "\"", 106, 1);
#nullable restore
#line 4 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
WriteAttributeValue("", 95, Model.Name, 95, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <h2>");
#nullable restore
#line 5 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 6 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
      
        double price = Model.Price;
        double priceSale = Model.GetDiscountPrice(Model);
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
     if(price != priceSale){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Цена: <s>");
#nullable restore
#line 11 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
               Write(price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</s>, ");
#nullable restore
#line 11 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
                                         Write(priceSale.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", скидка ");
#nullable restore
#line 11 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
                                                                          Write(Model.GetSale(Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n");
#nullable restore
#line 12 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Цена: ");
#nullable restore
#line 14 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
            Write(Model.GetDiscountPrice(Model).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Производитель: ");
#nullable restore
#line 16 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
                 Write(Model.Manufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677987fec11aec66a85599e387944abd521a8ff07875", async() => {
                WriteLiteral("Добавить в корзину");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\Shared\AllProducts.cshtml"
                                                                                     WriteLiteral(Model.Id);

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
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
