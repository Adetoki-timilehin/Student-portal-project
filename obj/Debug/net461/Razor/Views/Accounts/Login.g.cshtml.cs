#pragma checksum "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c6b57cbbfd6292405a29cefa39f347c89d2770"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Login), @"mvc.1.0.view", @"/Views/Accounts/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Login.cshtml", typeof(AspNetCore.Views_Accounts_Login))]
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
#line 1 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\_ViewImports.cshtml"
using StudentPortal;

#line default
#line hidden
#line 2 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\_ViewImports.cshtml"
using StudentPortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c6b57cbbfd6292405a29cefa39f347c89d2770", @"/Views/Accounts/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad5d583c5e827b0bddc7b680c7341442418c0bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Accounts/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Login.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
            BeginContext(37, 20, true);
            WriteLiteral("\r\n<h2>Login</h2>\r\n\r\n");
            EndContext();
            BeginContext(57, 694, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c6b57cbbfd6292405a29cefa39f347c89d27704901", async() => {
                BeginContext(138, 58, true);
                WriteLiteral("\r\n    <!-- ... -->\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(197, 25, false);
#line 10 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Login.cshtml"
   Write(Html.Label("User Email:"));

#line default
#line hidden
                EndContext();
                BeginContext(222, 176, true);
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <input type=\"text\" name=\"userEmail\" class=\"form-control\" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(399, 23, false);
#line 17 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Login.cshtml"
   Write(Html.Label("Password:"));

#line default
#line hidden
                EndContext();
                BeginContext(422, 322, true);
                WriteLiteral(@"
        <div class=""col-md-10"">
            <input type=""password"" name=""password"" class=""form-control"" />
        </div>
    </div>

    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
            <button type=""submit"" class=""btn btn-primary"">Login</button>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(751, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(756, 24, false);
#line 30 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Login.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(780, 770, true);
            WriteLiteral(@"

<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.12/jquery.validate.unobtrusive.min.js""></script>

<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>

<script>
    $(document).ready(function () {
        // Show/hide student field based on checkbox value

        var $studentField = $("".student-field"");
        var $isStudentCheckbox = $("".student-checkbox"");

        $isStudentCheckbox.change(function () {
            if (this.checked) {
                $studentField.show();
            } else {
                $studentField.hide();
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
