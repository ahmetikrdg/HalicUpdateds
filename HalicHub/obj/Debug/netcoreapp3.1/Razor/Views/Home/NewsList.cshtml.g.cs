#pragma checksum "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\NewsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89a95269c1cc1dc549a5866292b36e4853e09b70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsList), @"mvc.1.0.view", @"/Views/Home/NewsList.cshtml")]
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
#line 1 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\_ViewImports.cshtml"
using HalicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\_ViewImports.cshtml"
using Halic.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89a95269c1cc1dc549a5866292b36e4853e09b70", @"/Views/Home/NewsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\NewsList.cshtml"
Write(await Html.PartialAsync("_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""banner_area slider-m"">
    <div class=""banner_inner d-flex align-items-center"">
        <div class=""overlay bg-parallax"" data-stellar-ratio=""0.9"" data-stellar-vertical-offset=""0"" data-background=""""></div>
        <div class=""container"">
            <div class=""banner_content"">
                <h2>Cartridge Is Better Than Ever A Discount Toner</h2>
                <div class=""page_link"">
                    <a href=""index.html"">Anasayfa</a>
                    <a href=""category.html"">Haberler</a>
                </div>
            </div>
        </div>
    </div>
</section>
");
            WriteLiteral("\n<section>\n    <div class=\"container my-5\">\n        <div class=\"row\">\n");
#nullable restore
#line 22 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\NewsList.cshtml"
             foreach (var item in Model.News)
            {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\NewsList.cshtml"
               Write(await Html.PartialAsync("_NewsList", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\NewsList.cshtml"
                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>\n    ");
#nullable restore
#line 28 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\NewsList.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591