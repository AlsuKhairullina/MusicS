#pragma checksum "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Categories/Keyboards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da6d57e0e785693cc2853b56334a15835856fa9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MusicS.Pages.Categories.Views_Categories_Keyboards), @"mvc.1.0.view", @"/Views/Categories/Keyboards.cshtml")]
namespace MusicS.Pages.Categories
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
#line 1 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/_ViewImports.cshtml"
using MusicS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Categories/Keyboards.cshtml"
using MusicS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da6d57e0e785693cc2853b56334a15835856fa9d", @"/Views/Categories/Keyboards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7536900daae2397c24aaf833033435412351f737", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Keyboards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Categories/Keyboards.cshtml"
  
    ViewBag.Title = "Клавишные";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container d-flex justify-content-center mt-50 mb-50\">\n    <div class=\"row\">\n");
#nullable restore
#line 11 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Categories/Keyboards.cshtml"
          
            foreach (var product in Model)
            {
                if (product.Category == (Categories) 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 mt-2\">\n                        <div class=\"card\">\n                            <div class=\"card-body\">\n                                <div class=\"card-img-actions\"> <img");
            BeginWriteAttribute("src", " src=\"", 553, "\"", 576, 1);
#nullable restore
#line 19 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Categories/Keyboards.cshtml"
WriteAttributeValue("", 559, product.ImageUrl, 559, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img img-fluid\" width=\"96\" height=\"350\"");
            BeginWriteAttribute("alt", " alt=\"", 628, "\"", 634, 0);
            EndWriteAttribute();
            WriteLiteral(@"> </div>
                            </div>
                            <div class=""card-body bg-light text-center"">
                                <div class=""mb-2"">
                                    <h6 class=""font-weight-semibold mb-2""> <a href=""/Home/Product"" class=""text-default mb-2"" data-abc=""true"">");
#nullable restore
#line 23 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Categories/Keyboards.cshtml"
                                                                                                                                        Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </h6> <a href=\"#\" class=\"text-muted\" data-abc=\"true\">");
#nullable restore
#line 23 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Categories/Keyboards.cshtml"
                                                                                                                                                                                                               Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                </div>\n                                <h3 class=\"mb-0 font-weight-semibold\">");
#nullable restore
#line 25 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Categories/Keyboards.cshtml"
                                                                 Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                <div> <i class=""fa fa-star star""></i> <i class=""fa fa-star star""></i> <i class=""fa fa-star star""></i> <i class=""fa fa-star star""></i> </div>
                                <button type=""button"" class=""btn bg-cart""><i class=""fa fa-cart-plus mr-2""></i> Добавить в корзину</button>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 31 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Categories/Keyboards.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591