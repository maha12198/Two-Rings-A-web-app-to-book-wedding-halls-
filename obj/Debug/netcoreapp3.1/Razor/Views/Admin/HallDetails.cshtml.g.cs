#pragma checksum "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cd86b7fe3f4cc2dcacbf6ca19284de76e4dfa7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_HallDetails), @"mvc.1.0.view", @"/Views/Admin/HallDetails.cshtml")]
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
#line 1 "C:\Users\Merit\Downloads\meret work\Final Project\Views\_ViewImports.cshtml"
using Final_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Merit\Downloads\meret work\Final Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
using Final_Project.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd86b7fe3f4cc2dcacbf6ca19284de76e4dfa7a", @"/Views/Admin/HallDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fb7ef317ae05155a488c52b2e91b7ab94cdc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_HallDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Final_Project.Models.ViewModels.HallVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
  
    ViewData["Title"] = "HallDetails";
    Layout = "~/Views/Shared/Admin/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1  >Hall Images</h1>

 <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                   <ol class=""carousel-indicators"">

");
#nullable restore
#line 17 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                         for (int i = 0; i < Model.Gallery.Count(); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 19 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 674, "\"", 706, 2);
#nullable restore
#line 19 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
WriteAttributeValue("", 682, i==0 ? "active" : "", 682, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 705, "", 706, 1, true);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 20 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ol>\r\n                    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 23 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                         for (int i = 0; i < Model.Gallery.Count(); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 952, "\"", 1011, 2);
#nullable restore
#line 25 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
WriteAttributeValue("", 960, i==0 ? "carousel-item active" : "carousel-item", 960, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1010, "", 1011, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1073, "\"", 1100, 1);
#nullable restore
#line 26 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
WriteAttributeValue("", 1079, Model.Gallery[i].URL, 1079, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1101, "\"", 1129, 1);
#nullable restore
#line 26 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
WriteAttributeValue("", 1107, Model.Gallery[i].Name, 1107, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n");
#nullable restore
#line 28 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
           
      
            <div class=""col-md-6"">
                <div class=""row"">
                    <div class=""col-md-12""> 
                     
                              
                        <h1 >");
#nullable restore
#line 49 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-12 "">
                        <span class=""label "" style=""font-size:30px"">location: </span>
                        <span  style=""font-size:30px"">");
#nullable restore
#line 56 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                                                 Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>

                  <div class=""row"">
                    <div class=""col-md-12 "">
                        <span class=""label "" style=""font-size:30px"">Managed By: </span>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cd86b7fe3f4cc2dcacbf6ca19284de76e4dfa7a9757", async() => {
                WriteLiteral(" ");
#nullable restore
#line 63 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                                                                                                       Write(Model.mangerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("  <i class=\"nav-icon fas fa-solid fa-link\"></i>");
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
#line 63 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                                                       WriteLiteral(Model.mangerid);

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
            WriteLiteral(@"
                       
                    </div>
                </div>

              
                  <div class=""row"">
                    <div class=""col-md-12 "">
                        <span class=""label "" style=""font-size:30px"">Price: </span>
                        <span  style=""font-size:30px"">");
#nullable restore
#line 72 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                                                 Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>

<div class=""row"">
                    <div class=""col-md-12 "">
                        <span class=""label "" style=""font-size:30px"">Number Of Packages: </span>
                        <span  style=""font-size:30px"">");
#nullable restore
#line 79 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Admin\HallDetails.cshtml"
                                                 Write(context.HallPackages.Where(h=>h.HallId==@Model.Id).ToList().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <br />\r\n        <br />\r\n");
            WriteLiteral("      </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Final_Project.Models.ViewModels.HallVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
