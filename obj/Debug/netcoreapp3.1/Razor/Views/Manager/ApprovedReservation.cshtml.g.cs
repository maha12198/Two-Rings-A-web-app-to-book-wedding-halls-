#pragma checksum "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7043feb9acfdf1ec7551d58148500f3c5bc49fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_ApprovedReservation), @"mvc.1.0.view", @"/Views/Manager/ApprovedReservation.cshtml")]
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
#line 1 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
using Final_Project.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7043feb9acfdf1ec7551d58148500f3c5bc49fd5", @"/Views/Manager/ApprovedReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fb7ef317ae05155a488c52b2e91b7ab94cdc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_ApprovedReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Final_Project.Models.Hall>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
  
    ViewData["Title"] = "ApprovedReservation";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <main role=\"main\" class=\"pb-3\">\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <br/>\r\n        \r\n");
#nullable restore
#line 17 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
Write(Html.ActionLink("Back to new reservation","Index","Manager"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n       \r\n        <br />\r\n        <br/>\r\n        \r\n\r\n");
#nullable restore
#line 25 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
 if(Model.Count() != 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
     foreach(var item1 in Model)
            {
                var HallReservetions = context.UserBookHalls.Where(u => u.HallId == item1.id && u.approved==true).ToList();
    if (HallReservetions.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("               <h1>\r\n               ");
#nullable restore
#line 34 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
          Write(item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
               </h1>
         <table class=""table table-hover"">
    <thead>
        <tr>
            <th>
           UserName
            </th>
       

              <th>
                 Phone
            </th>

              <th>
                Another Phone
            </th>

            <th>
              Reservation Day
            </th>
            <th>
                Package
            </th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 62 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
         foreach(var item2 in HallReservetions)
    {
        var user = context.Users.Where(u => u.Id == item2.UserId).FirstOrDefault();
            if(user != null)
            {
               


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
           Write(user.First_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 71 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
                            Write(user.Last_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
           Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n             <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
           Write(item2.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            ");
#nullable restore
#line 82 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
       Write(item2.RequiredDay.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n           <td>\r\n          ");
#nullable restore
#line 86 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
     Write(context.HallPackages.Where(p=>p.Id==item2.PackageId).FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 90 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
            }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 94 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
     }
     else{

#line default
#line hidden
#nullable disable
            WriteLiteral("              <h1>\r\n               ");
#nullable restore
#line 97 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
          Write(item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               </h1>\r\n");
            WriteLiteral("         <h1 style=\"text-align:center\">\r\n             No Approved registeration For Now\r\n        </h1>\r\n");
#nullable restore
#line 103 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
     }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <h1 style=\"text-align:center\">\r\n             No Halls registered for you right now\r\n        </h1>\r\n");
#nullable restore
#line 111 "C:\Users\Merit\Downloads\meret work\Final Project\Views\Manager\ApprovedReservation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </main>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Final_Project.Models.Hall>> Html { get; private set; }
    }
}
#pragma warning restore 1591