#pragma checksum "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44deb60dab671fb473e94ff6a2ac2cd3150bc8fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VideoFirst_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VideoFirst/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44deb60dab671fb473e94ff6a2ac2cd3150bc8fa", @"/Views/Shared/Components/VideoFirst/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VideoFirst_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"td_wrapper_player td_wrapper_playlist_player_youtube\" data-first-video=\"\" data-autoplay=\"1\">\n    <div id=\"player_youtube\" style=\"height: 100%\">\n");
#nullable restore
#line 5 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
         foreach (var item in Model.Videos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <iframe id=\"iframeAJtDXIazrMo\"");
            BeginWriteAttribute("src", " src=\"", 271, "\"", 316, 2);
            WriteAttributeValue("", 277, "https://www.youtube.com/embed/", 277, 30, true);
#nullable restore
#line 7 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
WriteAttributeValue("", 307, item.Url, 307, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 413, "\"", 431, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>");
#nullable restore
#line 7 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
                                                                                                                                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n<div class=\"td_container_video_playlist \">\n    <div class=\"td_video_controls_playlist_wrapper\">\n        <div class=\"td_video_stop_play_control\">\n");
#nullable restore
#line 14 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
             foreach (var item in Model.Videos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"td-sp-video-play td-sp td_youtube_control\"");
            BeginWriteAttribute("onlclick", " onlclick=\"", 734, "\"", 760, 3);
            WriteAttributeValue("", 745, "play(", 745, 5, true);
#nullable restore
#line 16 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
WriteAttributeValue("", 750, item.Url, 750, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 759, ")", 759, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n            </a>");
#nullable restore
#line 17 "C:\Source\Workspaces\Halic_Hub\HalicHub\HalicHub\Views\Shared\Components\VideoFirst\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a class=""td-sp-video-play td-sp td_youtube_control"" onlclick=""play(AJtDXIazrMo)"">
            </a>
        </div>
        <div class=""td_current_video_play_title_youtube td_video_title_playing"">
            Video Playlist

        </div>
        <div class=""td_current_video_play_time_youtube td_video_time_playing"">
        </div>
    </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591