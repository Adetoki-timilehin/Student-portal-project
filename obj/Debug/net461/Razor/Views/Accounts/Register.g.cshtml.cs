#pragma checksum "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfce8386494a53ef2fe4a031122a4d67e56567cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Register), @"mvc.1.0.view", @"/Views/Accounts/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Register.cshtml", typeof(AspNetCore.Views_Accounts_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfce8386494a53ef2fe4a031122a4d67e56567cf", @"/Views/Accounts/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad5d583c5e827b0bddc7b680c7341442418c0bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentPortal.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Accounts/Register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
  
    ViewBag.Title = "Register";

#line default
#line hidden
            BeginContext(76, 23, true);
            WriteLiteral("\r\n<h2>Register</h2>\r\n\r\n");
            EndContext();
            BeginContext(99, 2701, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfce8386494a53ef2fe4a031122a4d67e56567cf5055", async() => {
                BeginContext(183, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(190, 23, false);
#line 10 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(213, 42, true);
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(256, 74, false);
#line 13 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
   Write(Html.LabelFor(m => m.UserEmail, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(330, 47, true);
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
                EndContext();
                BeginContext(378, 66, false);
#line 15 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.TextBoxFor(m => m.UserEmail, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(444, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(459, 43, false);
#line 16 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.UserEmail));

#line default
#line hidden
                EndContext();
                BeginContext(502, 70, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(573, 74, false);
#line 21 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
   Write(Html.LabelFor(m => m.FirstName, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(647, 47, true);
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
                EndContext();
                BeginContext(695, 66, false);
#line 23 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(761, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(776, 43, false);
#line 24 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(819, 70, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(890, 73, false);
#line 29 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
   Write(Html.LabelFor(m => m.LastName, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(963, 47, true);
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
                EndContext();
                BeginContext(1011, 65, false);
#line 31 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1076, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1091, 42, false);
#line 32 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1133, 192, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <div class=\"checkbox\">\r\n                <label>\r\n                    ");
                EndContext();
                BeginContext(1326, 87, false);
#line 40 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
               Write(Html.CheckBoxFor(m => m.IsStudent, new { @class = "student-checkbox", value = "true" }));

#line default
#line hidden
                EndContext();
                BeginContext(1413, 84, true);
                WriteLiteral("\r\n                    Are you a student?\r\n                </label>\r\n                ");
                EndContext();
                BeginContext(1498, 57, false);
#line 43 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
           Write(Html.HiddenFor(m => m.IsStudent, new { value = "false" }));

#line default
#line hidden
                EndContext();
                BeginContext(1555, 127, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group student-field\" style=\"display: none;\">\r\n        ");
                EndContext();
                BeginContext(1683, 73, false);
#line 49 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
   Write(Html.LabelFor(m => m.MatricNo, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(1756, 47, true);
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
                EndContext();
                BeginContext(1804, 65, false);
#line 51 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.TextBoxFor(m => m.MatricNo, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1869, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1884, 42, false);
#line 52 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.MatricNo));

#line default
#line hidden
                EndContext();
                BeginContext(1926, 70, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(1997, 73, false);
#line 57 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
   Write(Html.LabelFor(m => m.Password, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(2070, 47, true);
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
                EndContext();
                BeginContext(2118, 66, false);
#line 59 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2184, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2199, 42, false);
#line 60 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(2241, 70, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(2312, 80, false);
#line 65 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(2392, 47, true);
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
                EndContext();
                BeginContext(2440, 73, false);
#line 67 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2513, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2528, 49, false);
#line 68 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.ConfirmPassword));

#line default
#line hidden
                EndContext();
                BeginContext(2577, 216, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Register</button>\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(2800, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2805, 24, false);
#line 79 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Accounts\Register.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(2829, 774, true);
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
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentPortal.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591