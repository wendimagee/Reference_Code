#pragma checksum "C:\Users\wendi\source\repos\assessment-6-wendimagee\Assessment6\Assessment6\Views\Home\CountriesByContinent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3200384aa7b09bb0b6c8495bb29a5c738a28ea49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CountriesByContinent), @"mvc.1.0.view", @"/Views/Home/CountriesByContinent.cshtml")]
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
#line 1 "C:\Users\wendi\source\repos\assessment-6-wendimagee\Assessment6\Assessment6\Views\_ViewImports.cshtml"
using Assessment6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wendi\source\repos\assessment-6-wendimagee\Assessment6\Assessment6\Views\_ViewImports.cshtml"
using Assessment6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3200384aa7b09bb0b6c8495bb29a5c738a28ea49", @"/Views/Home/CountriesByContinent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b567c9ee01dfbbabec9c7da0e4ab405d25cc65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CountriesByContinent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Country>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "C:\Users\wendi\source\repos\assessment-6-wendimagee\Assessment6\Assessment6\Views\Home\CountriesByContinent.cshtml"
Write(Model[0].Continent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\wendi\source\repos\assessment-6-wendimagee\Assessment6\Assessment6\Views\Home\CountriesByContinent.cshtml"
 foreach (Country country in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>Name: ");
#nullable restore
#line 8 "C:\Users\wendi\source\repos\assessment-6-wendimagee\Assessment6\Assessment6\Views\Home\CountriesByContinent.cshtml"
             Write(country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n    </ul>\r\n");
#nullable restore
#line 10 "C:\Users\wendi\source\repos\assessment-6-wendimagee\Assessment6\Assessment6\Views\Home\CountriesByContinent.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591
