#pragma checksum "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1285603d717750a2c6e62c1ffeeca5dbf55d5d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\_ViewImports.cshtml"
using ActivityGame;

#line default
#line hidden
#line 2 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\_ViewImports.cshtml"
using ActivityGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1285603d717750a2c6e62c1ffeeca5dbf55d5d3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08d3c6e7672e8d60e718c71e3c4eca3d0119cf84", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivityGame>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(66, 560, true);
            WriteLiteral(@"<script>
   // $('document').ready(function(){
                
    //    $('.play').click(function(e){
      //      e.preventDefault()
    //        $.get(""/test"",function(data){
    //            data = JSON.parse(data);
        //        console.log(data);
          //  })
            
   // })
//})
</script>
<div class=""jumbotron jumbotron-fluid"">
    <div class=""container"">
        <h1 class=""display-3"">Dojodachi</h1>
        <p class=""lead"">Here is a dojodachi</p>
        <hr class=""my-2"">
        <div class=""text-center m-3""><p>");
            EndContext();
            BeginContext(627, 9, false);
#line 23 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\Home\Index.cshtml"
                                   Write(Model.Log);

#line default
#line hidden
            EndContext();
            BeginContext(636, 147, true);
            WriteLiteral("</p>\r\n        <div class=\"d-flex justify-content-between\">\r\n            <div class=\"flex-columm\">\r\n                <p>Meals</p> <progress id=\"file\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 783, "\"", 803, 1);
#line 26 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\Home\Index.cshtml"
WriteAttributeValue("", 792, Model.Meal, 792, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(804, 76, true);
            WriteLiteral(" max=\"100\"> </progress>\r\n                <p>Fullness</p> <progress id=\"file\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 880, "\"", 904, 1);
#line 27 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\Home\Index.cshtml"
WriteAttributeValue("", 889, Model.Fullness, 889, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(905, 73, true);
            WriteLiteral(" max=\"100\"></progress>\r\n                <p>Energy</p> <progress id=\"file\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 978, "\"", 1000, 1);
#line 28 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\Home\Index.cshtml"
WriteAttributeValue("", 987, Model.Energy, 987, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1001, 76, true);
            WriteLiteral(" max=\"100\"></progress>\r\n                <p>Happiness</p> <progress id=\"file\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 1077, "\"", 1102, 1);
#line 29 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\Home\Index.cshtml"
WriteAttributeValue("", 1086, Model.Happiness, 1086, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1103, 61, true);
            WriteLiteral(" max=\"100\"></progress>\r\n            </div>\r\n       <div> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1164, "\"", 1180, 1);
#line 31 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\ActivityGame\Views\Home\Index.cshtml"
WriteAttributeValue("", 1170, Model.Img, 1170, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1181, 436, true);
            WriteLiteral(@" height=""250px"" alt=""""> </div>
        </div>

        <p class=""lead mt-3 text-center"">
            <a href=""/play""><button class=""play btn-dark"">play</button></a>
            <a href=""/work""><button class=""work btn-dark"">work</button></a>
            <a href=""/sleep""><button class=""sleep btn-dark"">sleep</button></a>
            <a href=""/feed""><button class=""feed btn-dark"">feed</button></a>
        </p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityGame> Html { get; private set; }
    }
}
#pragma warning restore 1591