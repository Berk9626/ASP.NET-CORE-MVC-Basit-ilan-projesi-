#pragma checksum "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\Home\ListKonut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5febf7d8fd1733037ff321ac890a6fd2839ee940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListKonut), @"mvc.1.0.view", @"/Views/Home/ListKonut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListKonut.cshtml", typeof(AspNetCore.Views_Home_ListKonut))]
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
#line 1 "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\_ViewImports.cshtml"
using IlanProjesi;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5febf7d8fd1733037ff321ac890a6fd2839ee940", @"/Views/Home/ListKonut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb9cafa4cc777532bc9a4f8aa9fa75a8376af77", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListKonut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IlanProjesi.Models.ArabaKonutIsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\Home\ListKonut.cshtml"
  
	ViewData["Title"] = "ListKonut";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\Home\ListKonut.cshtml"
 foreach (var item in Model.Konutlar)
{



#line default
#line hidden
            BeginContext(181, 358, true);
            WriteLiteral(@"<table class=""table table-bordered"">
	<thead>
		<tr class=""table-danger"">
			<hr />
			<hr />

			<th scope=""col"">Konut Id</th>
			<th scope=""col"">Konut Adres</th>
			<th scope=""col"">Konut Açıklama</th>
			<th scope=""col"">Konut Fiyat</th>
			<th scope=""col"">Konut Resim</th>


		</tr>
	</thead>


	<tbody>
		<tr class=""table-info"">
			<td>");
            EndContext();
            BeginContext(540, 12, false);
#line 31 "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\Home\ListKonut.cshtml"
           Write(item.KonutId);

#line default
#line hidden
            EndContext();
            BeginContext(552, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(567, 15, false);
#line 32 "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\Home\ListKonut.cshtml"
           Write(item.KonutAdres);

#line default
#line hidden
            EndContext();
            BeginContext(582, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(597, 18, false);
#line 33 "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\Home\ListKonut.cshtml"
           Write(item.KonutAçıklama);

#line default
#line hidden
            EndContext();
            BeginContext(615, 14, true);
            WriteLiteral("</td>\r\n\t\t\t<td>");
            EndContext();
            BeginContext(630, 15, false);
#line 34 "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\Home\ListKonut.cshtml"
           Write(item.KonutFiyat);

#line default
#line hidden
            EndContext();
            BeginContext(645, 18, true);
            WriteLiteral("</td>\r\n\t\t\t<td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 663, "\"", 685, 1);
#line 35 "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\Home\ListKonut.cshtml"
WriteAttributeValue("", 669, item.KonutResim, 669, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(686, 79, true);
            WriteLiteral(" style=\"width:100px; height:100px;\" /></td>\r\n\r\n\t\t</tr>\r\n\r\n\t</tbody>\r\n</table>\r\n");
            EndContext();
#line 41 "C:\Users\exper\source\repos\IlanProjesi\IlanProjesi\Views\Home\ListKonut.cshtml"



}

#line default
#line hidden
            BeginContext(774, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IlanProjesi.Models.ArabaKonutIsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
