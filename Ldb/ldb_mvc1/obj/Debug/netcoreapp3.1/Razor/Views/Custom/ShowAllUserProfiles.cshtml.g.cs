#pragma checksum "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bae47695120b9ad36fbadc385a89d4932b18585f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Custom_ShowAllUserProfiles), @"mvc.1.0.view", @"/Views/Custom/ShowAllUserProfiles.cshtml")]
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
#line 1 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\_ViewImports.cshtml"
using ldb_mvc1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\_ViewImports.cshtml"
using ldb_mvc1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae47695120b9ad36fbadc385a89d4932b18585f", @"/Views/Custom/ShowAllUserProfiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7ec220b53f3a976ea95aec1b0cec193edcb630", @"/Views/_ViewImports.cshtml")]
    public class Views_Custom_ShowAllUserProfiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ldb_mvc1.Models.UserProfile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bae47695120b9ad36fbadc385a89d4932b18585f3956", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ShowAllUserProfiles</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bae47695120b9ad36fbadc385a89d4932b18585f5029", async() => {
                WriteLiteral("\r\n<p>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bae47695120b9ad36fbadc385a89d4932b18585f5298", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.middleName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.sex));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.dob));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayNameFor(model => model.department));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n          \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
 foreach (var item in Model.ShowAllUserProfiles) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.firstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.middleName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.lastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.sex));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.dob));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.DisplayFor(modelItem => item.department));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        \r\n            <td>\r\n                ");
#nullable restore
#line 90 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.id },"Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                ");
#nullable restore
#line 91 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.id },"Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                ");
#nullable restore
#line 92 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { user_id = item.id },"Custom"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 95 "C:\Users\rouni\Documents\ldb\Ldb\ldb_mvc1\Views\Custom\ShowAllUserProfiles.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ldb_mvc1.Models.UserProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
