#pragma checksum "C:\Users\hiram\source\repos\Activity3Part1\Activity3Part1\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "442ffe1d9e79b4fc86b7b5eb68aa5216e5a61101"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\hiram\source\repos\Activity3Part1\Activity3Part1\Views\_ViewImports.cshtml"
using Activity3Part1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hiram\source\repos\Activity3Part1\Activity3Part1\Views\_ViewImports.cshtml"
using Activity3Part1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"442ffe1d9e79b4fc86b7b5eb68aa5216e5a61101", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f779a46669953dbd5148df77ec11dff721d6f6b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Activity3Part1.Models.CustomerModel>, Activity3Part1.Models.CustomerModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OnSelectCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<style>\r\n    ul {\r\n        list-style-type: none;\r\n    }\r\n\r\n    #customerInformationArea {\r\n        border: 1px solid black;\r\n        border-radius: 5px;\r\n        margin: 10px;\r\n        padding: 10px;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "442ffe1d9e79b4fc86b7b5eb68aa5216e5a611014489", async() => {
                WriteLiteral("\r\n    <ul>\r\n");
#nullable restore
#line 18 "C:\Users\hiram\source\repos\Activity3Part1\Activity3Part1\Views\Customer\Index.cshtml"
         foreach (var item in Model.Item1)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>\r\n                <input class=\"customerRadio\" type=\"radio\" name=\"Id\" id=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 553, "\"", 569, 1);
#nullable restore
#line 21 "C:\Users\hiram\source\repos\Activity3Part1\Activity3Part1\Views\Customer\Index.cshtml"
WriteAttributeValue("", 561, item.Id, 561, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <label>");
#nullable restore
#line 22 "C:\Users\hiram\source\repos\Activity3Part1\Activity3Part1\Views\Customer\Index.cshtml"
                  Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </li>\r\n");
#nullable restore
#line 24 "C:\Users\hiram\source\repos\Activity3Part1\Activity3Part1\Views\Customer\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <input type=\"submit\" id=\"selectCustomer\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div id=\"customerInformationArea\">\r\n    <p>");
#nullable restore
#line 29 "C:\Users\hiram\source\repos\Activity3Part1\Activity3Part1\Views\Customer\Index.cshtml"
  Write(Html.Partial("_CustomerDetails", Tuple.Create(Model.Item1, Model.Item2)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Activity3Part1.Models.CustomerModel>, Activity3Part1.Models.CustomerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
