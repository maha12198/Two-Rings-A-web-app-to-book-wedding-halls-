#pragma checksum "C:\Users\Merit\Downloads\meret work\Final Project\Views\Halls\UserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ea95af5141315545bc88a9ef598d52ef7dbc55e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Halls_UserDetails), @"mvc.1.0.view", @"/Views/Halls/UserDetails.cshtml")]
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
#line 1 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Halls\UserDetails.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ea95af5141315545bc88a9ef598d52ef7dbc55e", @"/Views/Halls/UserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fb7ef317ae05155a488c52b2e91b7ab94cdc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Halls_UserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Final_Project.Models.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Halls\UserDetails.cshtml"
  
    ViewData["Title"] = "UserDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
     <div class=""container"">
          <main role=""main"" class=""pb-3"">
          <br />

<h1 style=""text-align:center"">User Details</h1>
<div class=""container""> 
  <div class=""col-md-6"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <h1>");
#nullable restore
#line 18 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Halls\UserDetails.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-12 text-primary"">
                        <span class=""label label-primary"" style=""text-align:center"" >Full Name: </span>
                        <span style=""font-size:larger"" class=""monospaced"">");
#nullable restore
#line 25 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Halls\UserDetails.cshtml"
                                                                     Write(Model.First_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"monospaced\">");
#nullable restore
#line 26 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Halls\UserDetails.cshtml"
                                            Write(Model.Last_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n\r\n                       <div class=\"col-md-12 text-primary\">\r\n                        <span class=\"label label-primary\">Phone Number: &nbsp </span>\r\n                        <span class=\"monospaced\">");
#nullable restore
#line 31 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Halls\UserDetails.cshtml"
                                            Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n\r\n                       <div class=\"col-md-12 text-primary\">\r\n                        <span class=\"label label-primary\">Email: </span>\r\n                     <a");
            BeginWriteAttribute("href", " href = \"", 1421, "\"", 1449, 2);
            WriteAttributeValue("", 1430, "mailto:", 1430, 7, true);
#nullable restore
#line 36 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Halls\UserDetails.cshtml"
WriteAttributeValue("", 1437, Model.Email, 1437, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Send Email Message</a>\r\n                    </div>\r\n\r\n                        <div class=\"col-md-12 text-primary\">\r\n                        <span class=\"label label-primary\">Role: </span>\r\n                     \r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n                </div> \r\n                </div>\r\n\r\n                    </main>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Final_Project.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
