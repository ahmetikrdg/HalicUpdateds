#pragma checksum "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\Activities\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10ae1dde05aead2c9a78bcf8747712436a4afc36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Activities_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Activities/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10ae1dde05aead2c9a78bcf8747712436a4afc36", @"/Views/Shared/Components/Activities/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Activities_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivitiesListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""testimonials"">
    <div class=""container"">
        <h2 style=""text-align: center; margin-bottom: 2.5rem; font-size: 40px; color: #fff; font-weight: 600"">Etkinlikler</h2>
        <div class=""row"">
            <div class=""col-sm-12"">
                <div id=""customers-testimonials"" class=""owl-carousel"">
");
#nullable restore
#line 8 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\Activities\Default.cshtml"
                     foreach (var item in Model.activities)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\Activities\Default.cshtml"
                   Write(await Html.PartialAsync("_Activities", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\Activities\Default.cshtml"
                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivitiesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
