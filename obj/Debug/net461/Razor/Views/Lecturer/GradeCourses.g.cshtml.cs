#pragma checksum "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Lecturer\GradeCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d850288613b14feb5bb3cf9fb3cbd61c2e76512f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lecturer_GradeCourses), @"mvc.1.0.view", @"/Views/Lecturer/GradeCourses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lecturer/GradeCourses.cshtml", typeof(AspNetCore.Views_Lecturer_GradeCourses))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d850288613b14feb5bb3cf9fb3cbd61c2e76512f", @"/Views/Lecturer/GradeCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad5d583c5e827b0bddc7b680c7341442418c0bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Lecturer_GradeCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(21, 39, true);
            WriteLiteral("\r\n<h1>Select a course to grade</h1>\r\n\r\n");
            EndContext();
            BeginContext(60, 287, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d850288613b14feb5bb3cf9fb3cbd61c2e76512f3757", async() => {
                BeginContext(129, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Lecturer\GradeCourses.cshtml"
     foreach (var course in Model)
    {

#line default
#line hidden
                BeginContext(174, 94, true);
                WriteLiteral("        <div>\r\n            <button class=\"course-button\" type=\"submit\" name=\"selectedCourseId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 268, "\"", 286, 1);
#line 9 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Lecturer\GradeCourses.cshtml"
WriteAttributeValue("", 276, course.Id, 276, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(287, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(289, 17, false);
#line 9 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Lecturer\GradeCourses.cshtml"
                                                                                              Write(course.CourseName);

#line default
#line hidden
                EndContext();
                BeginContext(306, 27, true);
                WriteLiteral("</button>\r\n        </div>\r\n");
                EndContext();
#line 11 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Lecturer\GradeCourses.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 5 "C:\Users\tadetoki\source\repos\StudentPortal\StudentPortal\Views\Lecturer\GradeCourses.cshtml"
AddHtmlAttributeValue("", 88, Url.Action("GradeCourses", "Lecturer"), 88, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
