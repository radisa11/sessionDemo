#pragma checksum "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb16e914e3d5b09433b2c98b4e0ea8e45e21221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Game), @"mvc.1.0.view", @"/Views/Home/Game.cshtml")]
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
#line 1 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\_ViewImports.cshtml"
using sessionDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\_ViewImports.cshtml"
using sessionDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb16e914e3d5b09433b2c98b4e0ea8e45e21221", @"/Views/Home/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f97de324c5e81d749938ff5264f7b154d0f44c89", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1 class=\"text-center\">Welcome ");
#nullable restore
#line 3 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
                           Write(ViewBag.User.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to Rock Paper Sissors</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"text-center col-6\">\r\n        <h2>");
#nullable restore
#line 7 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
       Write(ViewBag.User.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>");
#nullable restore
#line 8 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
       Write(ViewBag.User.hand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"text-center col-6\">\r\n        <h2>");
#nullable restore
#line 11 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
       Write(ViewBag.Oponent.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>");
#nullable restore
#line 12 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
       Write(ViewBag.Oponent.hand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n<div class=\"text-center\">\r\n    <a href=\"/playRound\" class=\"btn btn-danger\">Play round</a>\r\n    <h2>Score</h2>\r\n    <h3>");
#nullable restore
#line 18 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
   Write(ViewBag.User.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wins: ");
#nullable restore
#line 18 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
                              Write(ViewBag.PlayerOneWins);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 18 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
                                                       Write(ViewBag.Oponent.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wins: ");
#nullable restore
#line 18 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
                                                                                     Write(ViewBag.PlayerTwoWins);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Draws: ");
#nullable restore
#line 18 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
                                                                                                                     Write(ViewBag.Ties);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>Total rounds : ");
#nullable restore
#line 19 "C:\Users\Radisa\Desktop\MyCSharp\day6\sessionDemo\Views\Home\Game.cshtml"
                  Write(ViewBag.TotalPlays);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
