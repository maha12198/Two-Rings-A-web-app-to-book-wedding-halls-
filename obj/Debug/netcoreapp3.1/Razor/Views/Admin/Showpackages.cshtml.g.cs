#pragma checksum "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae38db9a322c3eece0dc36ab2dda3bd4667d8cee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Showpackages), @"mvc.1.0.view", @"/Views/Admin/Showpackages.cshtml")]
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
#line 1 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\_ViewImports.cshtml"
using Final_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae38db9a322c3eece0dc36ab2dda3bd4667d8cee", @"/Views/Admin/Showpackages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fb7ef317ae05155a488c52b2e91b7ab94cdc5a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Showpackages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Final_Project.Models.HallPackages>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdatePackage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePackage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
  
    ViewData["Title"] = "Showpackages";
    Layout = "~/Views/Shared/Admin/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 10 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
   if (TempData["deleted"] != null)
        {

            string deletdItem = TempData["deleted"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"alert alert-dismissible alert-warning\">\r\n            <h4 class=\"alert-heading\"> Deleted </h4>\r\n            <p class=\"mb-0\">");
#nullable restore
#line 16 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                       Write(deletdItem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" deleted successfully</p>\r\n        </div>\r\n");
#nullable restore
#line 18 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"


    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h1 style=\"text-align:center\">\r\n    No packages assigned for this hall yet\r\n    </h1>\r\n");
#nullable restore
#line 28 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Show packages for ");
#nullable restore
#line 31 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                     Write(Model.FirstOrDefault().Hall.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
              Number Of Persons
            </th>
            <th>
            Price
            </th>
            <th>
               Has Cake?
            </th>
            <th>
            Has Food?
            </th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 55 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberOfPersons));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n              <td>\r\n                ");
#nullable restore
#line 65 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n          \r\n");
#nullable restore
#line 68 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                     if (item.cake)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                       \r\n                    Yes\r\n                    </td>\r\n");
#nullable restore
#line 74 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <td>\r\n                       No\r\n                    </td>\r\n");
#nullable restore
#line 80 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                    if (item.food)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                       \r\n                    Yes\r\n                    </td>\r\n");
#nullable restore
#line 87 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <td>\r\n                       No\r\n                    </td>\r\n");
#nullable restore
#line 93 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae38db9a322c3eece0dc36ab2dda3bd4667d8cee10673", async() => {
                WriteLiteral("Edit Package");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" &nbsp \r\n                 \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae38db9a322c3eece0dc36ab2dda3bd4667d8cee12982", async() => {
                WriteLiteral(" <i class=\"fa fa-trash\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" &nbsp\r\n              \r\n                </td>\r\n        </tr>\r\n");
#nullable restore
#line 102 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 105 "D:\projects\two rings\Two-Rings-A-web-app-to-book-wedding-halls-\Views\Admin\Showpackages.cshtml"
    
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Final_Project.Models.HallPackages>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
