#pragma checksum "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\AdminPanel\Actions\AddSubCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9decdd961bca523217576d2028959218c32ccb14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Actions_AddSubCategory), @"mvc.1.0.view", @"/Views/AdminPanel/Actions/AddSubCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9decdd961bca523217576d2028959218c32ccb14", @"/Views/AdminPanel/Actions/AddSubCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b15390306cfbd4b3cd07a4c7fb774e311e310d45", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPanel_Actions_AddSubCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HookahsAndSmokingSystems.Models.Interfaces.ICategoryRepository>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\AdminPanel\Actions\AddSubCategory.cshtml"
  
    ViewData["Title"] = "AddSubCategory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"display-6 mb-1\">Добавление Статуса Заказа</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9decdd961bca523217576d2028959218c32ccb144099", async() => {
                WriteLiteral(@"

        <div class=""mt-5"">
            <h6 class=""fw-light"" style=""font-size: 22px"">Название статуса:</h6>
            <input type=""text"" style=""width: 250px; height: 40px; resize: none"" class=""mt-3 me-3"" name=""name""/>
        </div>
        <p class=""mt-3""/>
        
        ");
#nullable restore
#line 17 "D:\RiderProjects\HookahsAndSmokingSystems\HookahsAndSmokingSystems\Views\AdminPanel\Actions\AddSubCategory.cshtml"
   Write(Html.DropDownList("categoryName", Model.GetListElementsName().Select(s => new SelectListItem { Text = s.ToString(), Value = s.ToString() })));

#line default
#line hidden
#nullable disable
                WriteLiteral("     \r\n        \r\n        <br/>\r\n        <button class=\"btn btn-outline-secondary mt-5\" type=\"submit\">Добавить Статус для заказа</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HookahsAndSmokingSystems.Models.Interfaces.ICategoryRepository> Html { get; private set; }
    }
}
#pragma warning restore 1591
