#pragma checksum "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "655bc2d8e2cff6b9f7040d1930b69ec113257371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AuthorDetails), @"mvc.1.0.view", @"/Views/Home/AuthorDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"655bc2d8e2cff6b9f7040d1930b69ec113257371", @"/Views/Home/AuthorDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AuthorDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
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
                <h2>");
#nullable restore
#line 8 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
               Write(Model.Authors.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                <div class=""page_link"">
                    <a href=""index.html"">Anasayfa</a>
                    <a href=""category.html"">Yazarlar</a>
                </div>
            </div>
        </div>
    </div>
</section>
<section>
    <div class=""whole-wrap"">
        <div class=""container"">
            <div class=""section-top-border"" style=""padding-bottom: 0px"">
                <div class=""row"">
                    <div class=""col-md-3"" style=""margin-bottom: 30px"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "655bc2d8e2cff6b9f7040d1930b69ec1132573716567", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 920, "~/img/", 920, 6, true);
#nullable restore
#line 23 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
AddHtmlAttributeValue("", 926, Model.Authors.Image, 926, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                    <div class=\"col-md-9 mt-sm-20 left-align-p\">\n                        <blockquote class=\"generic-blockquote\">\n                            <span>");
#nullable restore
#line 27 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
                             Write(Model.Authors.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\n                            ");
#nullable restore
#line 28 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
                       Write(Html.Raw(Model.Authors.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </blockquote>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section>
    <div class=""container my-5"">
        <h2 style=""font-size: 30px; color: #140C40; font-weight: 500"">Yazara ait yayınlar</h2>
        <hr style=""border-color: #140C40 !important;"">
        <div class=""row"">
");
#nullable restore
#line 41 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
             foreach (var item in Model.News)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
Write(await Html.PartialAsync("_NewsList", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 45 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
             foreach (var item in Model.Articles)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
Write(await Html.PartialAsync("_ArticleList", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>\n\n");
#nullable restore
#line 52 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Home\AuthorDetails.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
