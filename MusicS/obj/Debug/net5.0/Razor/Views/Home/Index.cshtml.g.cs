#pragma checksum "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc55047cebfa14b3904272136b18be74bc26509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MusicS.Pages.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace MusicS.Pages.Home
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
#line 1 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
using MusicS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc55047cebfa14b3904272136b18be74bc26509", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7536900daae2397c24aaf833033435412351f737", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
  
    ViewBag.Title = "MusicStore";
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container d-flex justify-content-center mt-50 mb-50"">
    <div class=""col-md-4 mt-2"">
        <div class=""card"">
            <h4 class=""m-2 p-2 text-center"">Акция!</h4>
            <div class=""card-body"">
                <div class=""card-img-actions""> <img");
            BeginWriteAttribute("src", " src= \"", 381, "\"", 420, 1);
#nullable restore
#line 13 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
WriteAttributeValue("", 388, Model.FirstOrDefault().ImageUrl, 388, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img img-fluid"" width=""96"" height=""100"" alt=""alternative text""> </div>
            </div>
            <div class=""card-body bg-light text-center"">
                <div class=""mb-2"">
                    <h6 class=""font-weight-semibold mb-2""> <a href=""/Home/Product"" class=""text-default mb-2"" data-abc=""true"">");
#nullable restore
#line 17 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
                                                                                                                        Write(Model.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </h6> <a href=\"#\" class=\"text-muted\" data-abc=\"true\">");
#nullable restore
#line 17 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
                                                                                                                                                                                                              Write(Model.FirstOrDefault().Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </div>\n                <h3 class=\"mb-0 font-weight-semibold\">");
#nullable restore
#line 19 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
                                                 Write(Model.FirstOrDefault().Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" P</h3>
                <div> <i class=""fa fa-star star""></i> <i class=""fa fa-star star""></i> <i class=""fa fa-star star""></i> <i class=""fa fa-star star""></i> </div>
                <button type=""button"" class=""btn bg-cart""><i class=""fa fa-cart-plus mr-2""></i> Добавить в корзину</button>
            </div>
        </div>
    </div>
    
    <div>
        <div class=""container d-flex justify-content-center m-2 p-2"">
            <h4>Популярные товары</h4>
        </div>
        <div class=""container d-flex justify-content-center mt-50 mb-50"">
            <div class=""row"">
                
");
#nullable restore
#line 33 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
                  
                    int i = 0;
                    foreach (var product in Model)
                    {
                        i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4 mt-2\">\n                            <div class=\"card\">\n                                <div class=\"card-body\">\n                                    <div class=\"card-img-actions\"> <img");
            BeginWriteAttribute("src", " src=\"", 1940, "\"", 1963, 1);
#nullable restore
#line 41 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
WriteAttributeValue("", 1946, product.ImageUrl, 1946, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img img-fluid\" width=\"96\" height=\"350\"");
            BeginWriteAttribute("alt", " alt=\"", 2015, "\"", 2021, 0);
            EndWriteAttribute();
            WriteLiteral(@"> </div>
                                </div>
                                <div class=""card-body bg-light text-center"">
                                    <div class=""mb-2"">
                                        <h6 class=""font-weight-semibold mb-2""> <a href=""/Home/Product"" class=""text-default mb-2"" data-abc=""true"">");
#nullable restore
#line 45 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
                                                                                                                                            Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </h6> <a href=\"#\" class=\"text-muted\" data-abc=\"true\">");
#nullable restore
#line 45 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
                                                                                                                                                                                                                   Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    </div>\n                                    <h3 class=\"mb-0 font-weight-semibold\">");
#nullable restore
#line 47 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
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
#line 53 "/Users/alsuhajrullina/RiderProjects/MusicS/MusicS/Views/Home/Index.cshtml"
                        if (i == 3)
                            break;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <div class=""container d-flex justify-content-center m-2 p-2"">
            <h4>Производители</h4>
        </div>
        <div class=""container d-flex justify-content-center mt-50 mb-50"">
            <div class=""row"">
                <div class=""col-md-4 mt-2""> YAMAHA</div>
                <div class=""col-md-4 mt-2""> YAMAHA</div>
                <div class=""col-md-4 mt-2""> YAMAHA</div>
            </div>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591