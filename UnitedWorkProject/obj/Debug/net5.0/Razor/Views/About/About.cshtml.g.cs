#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\About\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c746d397513d7a63031fb0007b8d6fb76a3b9937"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_About), @"mvc.1.0.view", @"/Views/About/About.cshtml")]
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
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\_ViewImports.cshtml"
using UnitedWorkProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\_ViewImports.cshtml"
using UnitedWorkProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c746d397513d7a63031fb0007b8d6fb76a3b9937", @"/Views/About/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8116bbe16adfdabd91d8c2683a6703c6892fb89", @"/Views/_ViewImports.cshtml")]
    public class Views_About_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\About\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">");
#nullable restore
#line 10 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\About\About.cshtml"
                      Write(Model.AboutTittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        <div class=""row inner-sec"">
            <!--left-->
            <div class=""col-lg-12 left-blog-info-w3layouts-agileits text-left"">
                <div class=""blog-grid-top"">

                    <div class=""blog_info_left_grid"">
                        <a href=""single.html"">
                            <img");
            BeginWriteAttribute("src", " src=", 563, "", 586, 1);
#nullable restore
#line 18 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\About\About.cshtml"
WriteAttributeValue("", 568, Model.AboutImgUrl, 568, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 604, "\"", 610, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </a>\r\n                    </div>\r\n                    <h3>\r\n                        Kısaca bahsedicek olursam\r\n                    </h3>\r\n                    <p>\r\n                        ");
#nullable restore
#line 25 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\About\About.cshtml"
                   Write(Model.AboutDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <a href=""https://github.com/Sevgulketencii/UnitedSoftwareProject"" class=""btn btn-primary read-m"">Kaynak Kodlar İçin</a>
                </div>
                
            </div>
   
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; }
    }
}
#pragma warning restore 1591