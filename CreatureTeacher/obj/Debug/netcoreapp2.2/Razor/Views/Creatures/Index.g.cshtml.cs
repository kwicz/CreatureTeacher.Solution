#pragma checksum "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67d58e8e44c0924a3273a201329cef9272238c86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Creatures_Index), @"mvc.1.0.view", @"/Views/Creatures/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Creatures/Index.cshtml", typeof(AspNetCore.Views_Creatures_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/_ViewImports.cshtml"
using CreatureTeacher;

#line default
#line hidden
#line 5 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
using CreatureTeacher.Models;

#line default
#line hidden
#line 6 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d58e8e44c0924a3273a201329cef9272238c86", @"/Views/Creatures/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930d563035fbf74b8dfc0ca0abd0db7f045e0c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Creatures_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CreatureTeacher.Models.Creature>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(149, 34, true);
            WriteLiteral("\n\n<h1>Your Creature Friends!</h1>\n");
            EndContext();
#line 11 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(209, 448, true);
            WriteLiteral(@"  <p>Make a New Creature!</p>
    <div class=""demo-card-square mdl-card mdl-shadow--2dp"">
      <button class=""mdl-button mdl-js-button mdl-button--fab mdl-js-ripple-effect mdl-button--colored"">
        <i class=""material-icons"">add</i>
      </button>
              <div class=""mdl-card__actions mdl-card--border"">
          <a href=""/Creatures/Create"" class=""mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect"">Add New
            ");
            EndContext();
            BeginContext(658, 37, false);
#line 20 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
       Write(Html.ActionLink($"Add New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(695, 42, true);
            WriteLiteral("\n          </a>\n        </div>\n    </div>\n");
            EndContext();
#line 24 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
}

#line default
#line hidden
            BeginContext(739, 482, true);
            WriteLiteral(@"<div class=""mdl-grid"">
  <div class=""mdl-cell mdl-cell--4-col"">
    <div class=""demo-card-square mdl-card mdl-shadow--2dp"">
      <button class=""mdl-button mdl-js-button mdl-button--fab mdl-js-ripple-effect mdl-button--colored"">
        <i class=""material-icons"">add</i>
      </button>
              <div class=""mdl-card__actions mdl-card--border"">
          <a href=""/Creatures/Create"" class=""mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect"">Add New
            ");
            EndContext();
            BeginContext(1222, 37, false);
#line 33 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
       Write(Html.ActionLink($"Add New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 53, true);
            WriteLiteral("  \n          </a>\n        </div>\n    </div>\n  </div>\n");
            EndContext();
#line 38 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
     foreach(Creature creature in Model)
    {

#line default
#line hidden
            BeginContext(1359, 160, true);
            WriteLiteral("    <div class=\"mdl-cell mdl-cell--4-col\">\n      <div class=\"demo-card-square mdl-card mdl-shadow--2dp\">\n        <div class=\"mdl-card__title mdl-card--expand\">\n");
            EndContext();
            BeginContext(1554, 73, true);
            WriteLiteral("        </div>\n        <div class=\"mdl-card__supporting-text\">\n          ");
            EndContext();
            BeginContext(1628, 13, false);
#line 46 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
     Write(creature.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1641, 73, true);
            WriteLiteral("\n        </div>\n        <div class=\"mdl-card__actions mdl-card--border\">\n");
            EndContext();
            BeginContext(2009, 87, true);
            WriteLiteral("          <p class=\"mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect\">");
            EndContext();
            BeginContext(2097, 75, false);
#line 52 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
                                                                                  Write(Html.ActionLink("View Details", "Details", new { id = creature.CreatureId}));

#line default
#line hidden
            EndContext();
            BeginContext(2172, 45, true);
            WriteLiteral("</p>\n\n        </div>\n      </div>\n    </div>\n");
            EndContext();
#line 57 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2223, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CreatureTeacher.Models.Creature>> Html { get; private set; }
    }
}
#pragma warning restore 1591
