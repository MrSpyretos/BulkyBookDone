#pragma checksum "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd6f63c055cc4ddd3d82b6af3bf3b0171d6ff70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\_ViewImports.cshtml"
using BulkyBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\_ViewImports.cshtml"
using BulkyBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd6f63c055cc4ddd3d82b6af3bf3b0171d6ff70", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b283f6c8c7163b5f5d1f909d7b66a1ed4e3ccc1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BulkyBook.Models.ViewModels.CategoryVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/category.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-primary\">Category List </h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cd6f63c055cc4ddd3d82b6af3bf3b0171d6ff704813", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; Create New Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n<div class=\"p-4 border rounded\">\r\n");
#nullable restore
#line 18 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
     if (Model.Categories.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped border\">\r\n            <tr class=\"table-secondary\">\r\n                <th>Category Name</th>\r\n                <th></th>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"text-center\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 971, "\"", 1009, 2);
            WriteAttributeValue("", 978, "/Admin/Category/Upsert/", 978, 23, true);
#nullable restore
#line 33 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1001, item.Id, 1001, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success text-white"" style=""cursor:pointer"">
                                <i class=""fas fa-edit""></i>
                            </a>
                            &nbsp;
                            <button onclick=Delete(""/Admin/Category/Delete/");
#nullable restore
#line 37 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") class=\"btn btn-danger text-white\" style=\"cursor:pointer\">\r\n                                <i class=\"fas fa-trash-alt\"></i>\r\n                            </button>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        <div");
            BeginWriteAttribute("page-model", " page-model=\"", 1579, "\"", 1609, 1);
#nullable restore
#line 45 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1592, Model.PagingInfo, 1592, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" page-classes-enabled=\"true\" page-class=\"btn border\"\r\n             page-class-normal=\"btn btn-light\" page-class-selected=\"btn btn-info active\"\r\n             class=\"btn-group float-right\">\r\n        </div>\r\n        <br />\r\n");
#nullable restore
#line 50 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No Categories Exist.</p>\r\n");
#nullable restore
#line 54 "C:\Users\karakosp\Desktop\BulkBook\BulkyBookProject\BulkyBook\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        function Delete(url) {
            $.ajax({
                type: 'DELETE',
                url: url,
                success: function (data) {
                    location.reload();
                }
            })
        }
    </script>


");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral(@"<div class=""p-4 border rounded"">
    <table id=""tblData"" class=""table table-striped table-bordered"" style=""width:100%"">
        <thead class=""thead-dark"">
            <tr class=""table-info"">
                <th></th>
                <th></th>
            </tr>
        </thead>
    </table>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cd6f63c055cc4ddd3d82b6af3bf3b0171d6ff7010938", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BulkyBook.Models.ViewModels.CategoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
