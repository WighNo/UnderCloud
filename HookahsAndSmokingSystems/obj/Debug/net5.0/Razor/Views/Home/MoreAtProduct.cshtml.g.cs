#pragma checksum "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\Home\MoreAtProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad34cf18391ed7da0d0263131c2891bbaa519f00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MoreAtProduct), @"mvc.1.0.view", @"/Views/Home/MoreAtProduct.cshtml")]
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
#line 1 "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\_ViewImports.cshtml"
using HookahsAndSmokingSystems;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\_ViewImports.cshtml"
using HookahsAndSmokingSystems.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad34cf18391ed7da0d0263131c2891bbaa519f00", @"/Views/Home/MoreAtProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b15390306cfbd4b3cd07a4c7fb774e311e310d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MoreAtProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HookahsAndSmokingSystems.Models.Product.Product>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\Home\MoreAtProduct.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad34cf18391ed7da0d0263131c2891bbaa519f003641", async() => {
                WriteLiteral("\r\n    <title></title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad34cf18391ed7da0d0263131c2891bbaa519f004630", async() => {
                WriteLiteral("\r\n<div>\r\n    <div class=\"container mt-5\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h3 class=\"card-title\">");
#nullable restore
#line 18 "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\Home\MoreAtProduct.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-5 col-md-5 col-sm-6\">\r\n                        <div class=\"white-box text-center\"><img");
                BeginWriteAttribute("src", " src=\"", 497, "\"", 528, 1);
#nullable restore
#line 21 "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\Home\MoreAtProduct.cshtml"
WriteAttributeValue("", 503, Model.DisplayingImageUrl, 503, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-thumbnail\"></div>\r\n                    </div>\r\n                    <div class=\"col-lg-7 col-md-7 col-sm-6\">\r\n                        <h4 class=\"box-title\">Описание</h4>\r\n                        <p>");
#nullable restore
#line 25 "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\Home\MoreAtProduct.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <text class=\"display-5 align-bottom\">Цена: </text><text class=\"mt-5 display-6\">");
#nullable restore
#line 26 "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\Home\MoreAtProduct.cshtml"
                                                                                                  Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("₽<small class=\"text-success\"></small></text>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HookahsAndSmokingSystems.Models.Product.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591