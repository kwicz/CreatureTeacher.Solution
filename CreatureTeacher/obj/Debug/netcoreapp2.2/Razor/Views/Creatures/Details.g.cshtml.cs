#pragma checksum "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df8a80361aff789cb0064402e2b942adfa3c1bdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Creatures_Details), @"mvc.1.0.view", @"/Views/Creatures/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Creatures/Details.cshtml", typeof(AspNetCore.Views_Creatures_Details))]
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
#line 1 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/_ViewImports.cshtml"
using CreatureTeacher;

#line default
#line hidden
#line 5 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
using CreatureTeacher.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df8a80361aff789cb0064402e2b942adfa3c1bdf", @"/Views/Creatures/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930d563035fbf74b8dfc0ca0abd0db7f045e0c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Creatures_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreatureTeacher.Models.Creature>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(109, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(111, 36, false);
#line 8 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(147, 36, true);
            WriteLiteral("\'s Creature Features: \n<ul>\n    <li>");
            EndContext();
            BeginContext(184, 76, false);
#line 10 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
   Write(Html.ActionLink($"{Model.Eye}", "Details", "Eyes", new { id = Model.EyeId }));

#line default
#line hidden
            EndContext();
            BeginContext(260, 14, true);
            WriteLiteral("</li>\n    <li>");
            EndContext();
            BeginContext(275, 81, false);
#line 11 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
   Write(Html.ActionLink($"{Model.Mouth}", "Details", "Mouth", new { id = Model.MouthId }));

#line default
#line hidden
            EndContext();
            BeginContext(356, 14, true);
            WriteLiteral("</li>\n    <li>");
            EndContext();
            BeginContext(371, 78, false);
#line 12 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
   Write(Html.ActionLink($"{Model.Head}", "Details", "Head", new { id = Model.HeadId }));

#line default
#line hidden
            EndContext();
            BeginContext(449, 14, true);
            WriteLiteral("</li>\n    <li>");
            EndContext();
            BeginContext(464, 78, false);
#line 13 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
   Write(Html.ActionLink($"{Model.Tail}", "Details", "Tail", new { id = Model.TailId }));

#line default
#line hidden
            EndContext();
            BeginContext(542, 12, true);
            WriteLiteral("</li>\n</ul>\n");
            EndContext();
            BeginContext(555, 40, false);
#line 15 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(595, 499, true);
            WriteLiteral(@"<div class=""mdc-card demo-card demo-ui-control"">

<div class=""mdc-card demo-card"">
  <div class=""mdc-card__primary-action demo-card__primary-action"" tabindex=""0"">
    <div class=""mdc-card__media mdc-card__media--16-9 demo-card__media"" style=""background-image: url(&quot;https://material-components.github.io/material-components-web-catalog/static/media/photos/3x2/2.jpg&quot;);""></div>
    <div class=""demo-card__primary"">
      <h2 class=""demo-card__title mdc-typography mdc-typography--headline6"">");
            EndContext();
            BeginContext(1095, 36, false);
#line 21 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                                                                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 101, true);
            WriteLiteral("</h2>\n    </div>\n    <div class=\"demo-card__secondary mdc-typography mdc-typography--body2\">\n        ");
            EndContext();
            BeginContext(1233, 76, false);
#line 24 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
   Write(Html.ActionLink($"{Model.Eye}", "Details", "Eyes", new { id = Model.EyeId }));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(1319, 81, false);
#line 25 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
   Write(Html.ActionLink($"{Model.Mouth}", "Details", "Mouth", new { id = Model.MouthId }));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(1410, 78, false);
#line 26 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
   Write(Html.ActionLink($"{Model.Head}", "Details", "Head", new { id = Model.HeadId }));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(1498, 78, false);
#line 27 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
   Write(Html.ActionLink($"{Model.Tail}", "Details", "Tail", new { id = Model.TailId }));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 410, true);
            WriteLiteral(@"
    </div>
  </div>
  <div class=""mdc-card__actions"">
    <div class=""mdc-card__action-buttons"">
      <button class=""mdc-button mdc-card__action mdc-card__action--button"">  <span class=""mdc-button__ripple""></span> Back to Creatures</button>
      <button class=""mdc-button mdc-card__action mdc-card__action--button"">  <span class=""mdc-button__ripple""></span> Use as Parent</button>
    </div>
  </div>
</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreatureTeacher.Models.Creature> Html { get; private set; }
    }
}
#pragma warning restore 1591
