#pragma checksum "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\User\ViewUserSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17723dde32e6db33128570e001571c9cac5b3a74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewUserSettings), @"mvc.1.0.view", @"/Views/User/ViewUserSettings.cshtml")]
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
#nullable restore
#line 5 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17723dde32e6db33128570e001571c9cac5b3a74", @"/Views/User/ViewUserSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3813e58872bf94427e556df0543cd973e2eef980", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ViewUserSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17723dde32e6db33128570e001571c9cac5b3a744110", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ViewUserSettings</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17723dde32e6db33128570e001571c9cac5b3a745180", async() => {
                WriteLiteral("\r\n    <h1>Данные пользователя:</h1>\r\n");
#nullable restore
#line 9 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\User\ViewUserSettings.cshtml"
      
        foreach (var settings in Model.allUserSettings)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <h2>Имя пользователя: ");
#nullable restore
#line 13 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\User\ViewUserSettings.cshtml"
                                 Write(settings.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <p>Адрес пользователя: ");
#nullable restore
#line 14 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\User\ViewUserSettings.cshtml"
                                  Write(settings.Adress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <b>Баланс: ");
#nullable restore
#line 15 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\User\ViewUserSettings.cshtml"
                      Write(settings.Balance);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                <p>Потрачено: ");
#nullable restore
#line 16 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\User\ViewUserSettings.cshtml"
                         Write(settings.Spend);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Users\Николай\source\repos\MagazineShop\MagazineShop\Views\User\ViewUserSettings.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591