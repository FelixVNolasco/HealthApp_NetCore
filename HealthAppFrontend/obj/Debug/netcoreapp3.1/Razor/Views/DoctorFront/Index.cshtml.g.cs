#pragma checksum "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1609dff423d2bc9139f81e468ae00bfcad7da582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DoctorFront_Index), @"mvc.1.0.view", @"/Views/DoctorFront/Index.cshtml")]
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
#line 1 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\_ViewImports.cshtml"
using HealthAppFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\_ViewImports.cshtml"
using HealthAppFrontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1609dff423d2bc9139f81e468ae00bfcad7da582", @"/Views/DoctorFront/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977d62f7d4857fff6952e4a9584fdb4b68923d97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DoctorFront_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HealthAppFrontend.Models.DoctorFront>>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1609dff423d2bc9139f81e468ae00bfcad7da5823866", async() => {
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
#line 16 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 31 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.graduation_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.phone_number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 43 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 49 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.center));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 61 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 79 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.graduation_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.phone_number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 91 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 97 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.center));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 106 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 107 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 108 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 111 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\DoctorFront\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HealthAppFrontend.Models.DoctorFront>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
