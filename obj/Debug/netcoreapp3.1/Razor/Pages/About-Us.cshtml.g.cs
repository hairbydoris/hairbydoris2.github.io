#pragma checksum "/Users/linnerrivas/Development/freelancing/HairbyDoris_v3/hair-by-doris/Pages/About-Us.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b93f5c3572e11dabfe645cdb83bd42b2ea048e44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(hair_by_doris.Pages.Pages_About_Us), @"mvc.1.0.razor-page", @"/Pages/About-Us.cshtml")]
namespace hair_by_doris.Pages
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
#line 1 "/Users/linnerrivas/Development/freelancing/HairbyDoris_v3/hair-by-doris/Pages/_ViewImports.cshtml"
using hair_by_doris;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b93f5c3572e11dabfe645cdb83bd42b2ea048e44", @"/Pages/About-Us.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"616e0c3df3dc48dba0d39fdedc057da2d0d9a6fd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About_Us : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/linnerrivas/Development/freelancing/HairbyDoris_v3/hair-by-doris/Pages/About-Us.cshtml"
  
    ViewData["Title"] = "About Us";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""relative banner"">
  <video autoplay muted loop id=""VideoIntro"">
        <source src=""video/intro_salon.mp4"" type=""video/mp4"">
    </video>
</div>
<section class=""relative bg-yellow-600 py-8 px-4"">
    <div class=""z-20 relative container mx-auto"">
        <h1 class=""text-5xl  text-center text-white"">Instagram</h1>
        <div class=""elfsight-app-4b95c65e-6c05-4eca-9435-839544330e82""></div>
    </div>
  <div class=""absolute inset-0 h-auto z-10"">
    </div>
</section>
<section class=""relative bg-white pt-20 py-8 px-4"">
    <div class=""flex justify-center relative container mx-auto"">
        <h1 class=""text-5xl text-center text-yellow-600"">Call To Schedule an Appointment</h1>
    </div>
    <div class=""flex justify-center pt-10"">
        <button class=""bg-black hover:bg-yellow-600 text-white font-bold py-2 px-4 rounded-full""><a class=""hover:text-white"" href=""tel:203-880-9776"">Call Today</a></button>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_About_Us> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_About_Us> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_About_Us>)PageContext?.ViewData;
        public Pages_About_Us Model => ViewData.Model;
    }
}
#pragma warning restore 1591
