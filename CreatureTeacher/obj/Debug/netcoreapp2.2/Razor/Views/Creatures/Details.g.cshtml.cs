#pragma checksum "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b30286d82e445fb49878a03cdb13f89b6702c1"
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
#line 6 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
using CreatureTeacher.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b30286d82e445fb49878a03cdb13f89b6702c1", @"/Views/Creatures/Details.cshtml")]
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
            BeginContext(39, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(110, 15, true);
            WriteLiteral("<h1>Look! It\'s ");
            EndContext();
            BeginContext(126, 36, false);
#line 8 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(162, 263, true);
            WriteLiteral(@"!</h1>
	<div class=""row"">
    <div class=""col-md-6"">
			<div class=""details-card-square mdl-card mdl-shadow--2dp"">
				<div class=""mdl-card__title mdl-card--expand"">
					<img src=""../../img/creatureImages/bodies/body-blue.png"" width=""500"" id=""bodyImg"">
					<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 425, "\"", 494, 2);
            WriteAttributeValue("", 431, "../../img/creatureImages/mouths/", 431, 32, true);
#line 14 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
WriteAttributeValue("", 463, Url.Content(Model.Mouth.Image), 463, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(495, 37, true);
            WriteLiteral(" width=\"500\" id=\"mouthImg\">\n\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 532, "\"", 597, 2);
            WriteAttributeValue("", 538, "../../img/creatureImages/eyes/", 538, 30, true);
#line 15 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
WriteAttributeValue("", 568, Url.Content(Model.Eye.Image), 568, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(598, 36, true);
            WriteLiteral(" width=\"500\" id=\"eyesImg\">\n\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 634, "\"", 701, 2);
            WriteAttributeValue("", 640, "../../img/creatureImages/tails/", 640, 31, true);
#line 16 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
WriteAttributeValue("", 671, Url.Content(Model.Tail.Image), 671, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(702, 36, true);
            WriteLiteral(" width=\"500\" id=\"tailImg\">\n\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 738, "\"", 804, 2);
            WriteAttributeValue("", 744, "../../img/creatureImages/hair/", 744, 30, true);
#line 17 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
WriteAttributeValue("", 774, Url.Content(Model.Head.Image), 774, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(805, 27, true);
            WriteLiteral(" width=\"500\" id=\"headImg\">\n");
            EndContext();
#line 18 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                      
						Random random = new Random();
						int result = random.Next(1, 7);
						if (result == 1)
						{

#line default
#line hidden
            BeginContext(945, 95, true);
            WriteLiteral("\t\t\t\t\t\t\t<img src=\"../../img/creatureImages/items/item-birthday.png\" width=\"500\" id=\"accessory\">\n");
            EndContext();
#line 24 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
						}
						if (result == 2)
						{

#line default
#line hidden
            BeginContext(1079, 93, true);
            WriteLiteral("\t\t\t\t\t\t\t<img src=\"../../img/creatureImages/items/item-camera.png\" width=\"500\" id=\"accessory\">\n");
            EndContext();
#line 28 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
						}
						if (result == 3)
						{

#line default
#line hidden
            BeginContext(1211, 92, true);
            WriteLiteral("\t\t\t\t\t\t\t<img src=\"../../img/creatureImages/items/item-crown.png\" width=\"500\" id=\"accessory\">\n");
            EndContext();
#line 32 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
						}
						if (result == 4)
						{

#line default
#line hidden
            BeginContext(1342, 92, true);
            WriteLiteral("\t\t\t\t\t\t\t<img src=\"../../img/creatureImages/items/item-drink.png\" width=\"500\" id=\"accessory\">\n");
            EndContext();
#line 36 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
						}
						if (result == 5)
						{

#line default
#line hidden
            BeginContext(1473, 93, true);
            WriteLiteral("\t\t\t\t\t\t\t<img src=\"../../img/creatureImages/items/item-viking.png\" width=\"500\" id=\"accessory\">\n");
            EndContext();
#line 40 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
						}
						if (result == 6)
						{

#line default
#line hidden
            BeginContext(1605, 92, true);
            WriteLiteral("\t\t\t\t\t\t\t<img src=\"../../img/creatureImages/items/item-watch.png\" width=\"500\" id=\"accessory\">\n");
            EndContext();
#line 44 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
						}
					

#line default
#line hidden
            BeginContext(1713, 323, true);
            WriteLiteral(@"
				</div>
			</div>
		</div>
		<div class=""col-md-6"">
			<div class=""details-card-square mdl-card mdl-shadow--2dp"">
				<div class=""mdl-card__title mdl-card--expand"">
				<ul id=""detailList"" >This Creature's Features:
					<li class=""mdl-list__item"">
						<span class=""mdl-list__item-primary-content"">
								Eye Type: ");
            EndContext();
            BeginContext(2037, 80, false);
#line 56 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                                     Write(Html.ActionLink($"{Model.Eye.Name}", "Details", "Eye", new { id = Model.EyeId }));

#line default
#line hidden
            EndContext();
            BeginContext(2117, 143, true);
            WriteLiteral("\n\t\t\t\t\t\t</span>           \n\t\t\t\t\t</li>\n\t\t\t\t\t<li class=\"mdl-list__item\">\n\t\t\t\t\t\t\t<span class=\"mdl-list__item-primary-content\">\n\t\t\t\t\t\t\t\t\tEye Codon: ");
            EndContext();
            BeginContext(2261, 81, false);
#line 61 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                                          Write(Html.ActionLink($"{Model.Eye.Codon}", "Details", "Eye", new { id = Model.EyeId }));

#line default
#line hidden
            EndContext();
            BeginContext(2342, 145, true);
            WriteLiteral("\n\t\t\t\t\t\t\t</span>           \n\t\t\t\t\t</li>\n\t\t\t\t\t<li class=\"mdl-list__item\">\n\t\t\t\t\t\t\t<span class=\"mdl-list__item-primary-content\">\n\t\t\t\t\t\t\t\t\tMouth Type: ");
            EndContext();
            BeginContext(2488, 86, false);
#line 66 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                                           Write(Html.ActionLink($"{Model.Mouth.Name}", "Details", "Mouth", new { id = Model.MouthId }));

#line default
#line hidden
            EndContext();
            BeginContext(2574, 146, true);
            WriteLiteral("\n\t\t\t\t\t\t\t</span>           \n\t\t\t\t\t</li>\n\t\t\t\t\t<li class=\"mdl-list__item\">\n\t\t\t\t\t\t\t<span class=\"mdl-list__item-primary-content\">\n\t\t\t\t\t\t\t\t\tMouth Codon: ");
            EndContext();
            BeginContext(2721, 87, false);
#line 71 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                                            Write(Html.ActionLink($"{Model.Mouth.Codon}", "Details", "Mouth", new { id = Model.MouthId }));

#line default
#line hidden
            EndContext();
            BeginContext(2808, 144, true);
            WriteLiteral("\n\t\t\t\t\t\t\t</span>           \n\t\t\t\t\t</li>\n\t\t\t\t\t<li class=\"mdl-list__item\">\n\t\t\t\t\t\t\t<span class=\"mdl-list__item-primary-content\">\n\t\t\t\t\t\t\t\t\tHead Type: ");
            EndContext();
            BeginContext(2953, 83, false);
#line 76 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                                          Write(Html.ActionLink($"{Model.Head.Name}", "Details", "Head", new { id = Model.HeadId }));

#line default
#line hidden
            EndContext();
            BeginContext(3036, 145, true);
            WriteLiteral("\n\t\t\t\t\t\t\t</span>           \n\t\t\t\t\t</li>\n\t\t\t\t\t<li class=\"mdl-list__item\">\n\t\t\t\t\t\t\t<span class=\"mdl-list__item-primary-content\">\n\t\t\t\t\t\t\t\t\tHead Codon: ");
            EndContext();
            BeginContext(3182, 84, false);
#line 81 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                                           Write(Html.ActionLink($"{Model.Head.Codon}", "Details", "Head", new { id = Model.HeadId }));

#line default
#line hidden
            EndContext();
            BeginContext(3266, 144, true);
            WriteLiteral("\n\t\t\t\t\t\t\t</span>           \n\t\t\t\t\t</li>\n\t\t\t\t\t<li class=\"mdl-list__item\">\n\t\t\t\t\t\t\t<span class=\"mdl-list__item-primary-content\">\n\t\t\t\t\t\t\t\t\tTail Type: ");
            EndContext();
            BeginContext(3411, 83, false);
#line 86 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                                          Write(Html.ActionLink($"{Model.Tail.Name}", "Details", "Tail", new { id = Model.TailId }));

#line default
#line hidden
            EndContext();
            BeginContext(3494, 145, true);
            WriteLiteral("\n\t\t\t\t\t\t\t</span>           \n\t\t\t\t\t</li>\n\t\t\t\t\t<li class=\"mdl-list__item\">\n\t\t\t\t\t\t\t<span class=\"mdl-list__item-primary-content\">\n\t\t\t\t\t\t\t\t\tTail Codon: ");
            EndContext();
            BeginContext(3640, 84, false);
#line 91 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Details.cshtml"
                                           Write(Html.ActionLink($"{Model.Tail.Codon}", "Details", "Tail", new { id = Model.TailId }));

#line default
#line hidden
            EndContext();
            BeginContext(3724, 81, true);
            WriteLiteral("\n\t\t\t\t\t\t\t</span>           \n\t\t\t\t\t</li>\n\t\t\t\t</ul>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n</div>");
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
