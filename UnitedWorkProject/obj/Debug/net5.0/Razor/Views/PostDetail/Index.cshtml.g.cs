#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\PostDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b029a2fc5330858b068a4bc7920a77d54a156b1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PostDetail_Index), @"mvc.1.0.view", @"/Views/PostDetail/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b029a2fc5330858b068a4bc7920a77d54a156b1c", @"/Views/PostDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8116bbe16adfdabd91d8c2683a6703c6892fb89", @"/Views/_ViewImports.cshtml")]
    public class Views_PostDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\PostDetail\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
    <section class=""banner-bottom"">
        <!--/blog-->
        <div class=""container"">
            <div class=""row"">
                <!--left-->
                <div class=""col-lg-12 left-blog-info-w3layouts-agileits text-center"">
                    <div class=""blog-grid-top"">
                        <div class=""b-grid-top"">
                            <div class=""blog_info_left_grid"">
                                <a href=""single.html"">
                                    <img");
            BeginWriteAttribute("src", " src=", 609, "", 631, 1);
#nullable restore
#line 19 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\PostDetail\Index.cshtml"
WriteAttributeValue("", 614, Model.postImgUrl, 614, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 649, "\"", 655, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </a>\r\n                            </div>\r\n                           \r\n                        </div>\r\n\r\n                        <h3>\r\n                            <a href=\"single.html\">");
#nullable restore
#line 26 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\PostDetail\Index.cshtml"
                                             Write(Model.postTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                        </h3>\r\n                        <p>\r\n                            ");
#nullable restore
#line 29 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\PostDetail\Index.cshtml"
                       Write(Model.postDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        \r\n                    </div>\r\n\r\n                    ");
#nullable restore
#line 34 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\PostDetail\Index.cshtml"
               Write(await Component.InvokeAsync("_FoodPost"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 35 "C:\Users\Sevgül KETENCİ\Source\Repos\UnitedWorkProject\UnitedWorkProject\Views\PostDetail\Index.cshtml"
               Write(await Component.InvokeAsync("_FoodPostAdd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                    \r\n                </div>\r\n-\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostModel> Html { get; private set; }
    }
}
#pragma warning restore 1591