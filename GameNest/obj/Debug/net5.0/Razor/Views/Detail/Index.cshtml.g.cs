#pragma checksum "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27192cf19f815026e985f2c2bcc10618eedeb15b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detail_Index), @"mvc.1.0.view", @"/Views/Detail/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27192cf19f815026e985f2c2bcc10618eedeb15b", @"/Views/Detail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Detail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameNest.ViewModels.DetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-sortBy", "top", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm float-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-sortBy", "time", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("submitReview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js\"></script>\r\n<br />\r\n<div class=\"img-thumbnail d-flex flex-row bg-dark\" style=\"height:200px;min-width:100%;max-width:fit-content\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 304, "\"", 330, 1);
#nullable restore
#line 9 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
WriteAttributeValue("", 310, Model.game.ImageURL, 310, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 331, "\"", 337, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid flex-column"" style=""height:100%""/>
        <div class=""d-flex flex-column justify-content-around"">
                <div class=""d-flex flex-column justify-content-start"">
                <div class=""badge text-wrap"" style=""width: inherit;color:white"">
                    <h3>");
#nullable restore
#line 13 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                   Write(Model.game.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"badge text-wrap\" style=\"width: inherit;color:white;text-align:start\">\r\n                    <p class=\"h10\">\r\n                        ");
#nullable restore
#line 17 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                   Write(Model.game.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                </div>
                <div class=""d-flex flex-row justify-content-evenly"" style=""width: inherit; color:transparent"">
                    <div class=""badge bg-success text-wrap"">
                        A$");
#nullable restore
#line 23 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                     Write(Model.game.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                     <div class=\"badge text-wrap\">\r\n                        Overall Ratings: ");
#nullable restore
#line 26 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                                    Write(Model.game.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div class=""btn badge"" id=""wishlist"" onclick=""ToggleWishList();"" style=""background-color:grey"">
                        <svg id=""heart"" xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-heart-fill"" viewBox=""0 0 16 16"">
                            <path fill-rule=""evenodd"" d=""M8 1.314C12.438-3.248 23.534 4.735 8 15-7.534 4.736 3.562-3.248 8 1.314z""/>
                        </svg>
                        Wishlist it
                    </div>
                </div>
        </div>
</div>

<div class=""d-flex flex-column bg-light rounded shadow-sm p-4 mb-4"" style=""margin-top:50px"">
    <div class=""d-flex flex-row justify-content-between"">
        <h5 class=""mb-1"">All Ratings and Reviews</h5>
        <div class=""d-flex flex-row"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27192cf19f815026e985f2c2bcc10618eedeb15b8796", async() => {
                WriteLiteral("Top Rated");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                  WriteLiteral(Model.game.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortBy", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortBy"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div style=\"width:10px\"></div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27192cf19f815026e985f2c2bcc10618eedeb15b11775", async() => {
                WriteLiteral("Most Recent");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                  WriteLiteral(Model.game.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortBy", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortBy"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 51 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
     foreach(var review in Model.reviews)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex flex-column\" style=\"margin-top:50px\">\r\n            <div class=\"d-flex flex-row justify-content-between\">\r\n                <h6><a class=\"text-black\" href=\"#\">");
#nullable restore
#line 55 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                                              Write(review.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                <h6>Rating: ");
#nullable restore
#line 56 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                       Write(review.review.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n            <p class=\"text-gray align-self-end\">");
#nullable restore
#line 58 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                                           Write(review.review.CreateDateUTC.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"reviews-members-body\">\r\n                <p>");
#nullable restore
#line 60 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
              Write(review.review.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 63 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 65 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
 if(Model.user!=null&&!Model.reviews.Any(n => n.review.UserId == Model.user.Id))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"bg-light rounded shadow-sm p-4 mb-5\">\r\n    <h5 class=\"mb-4\">Write Review</h5>\r\n    <p class=\"mb-2\">Rate the Game</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27192cf19f815026e985f2c2bcc10618eedeb15b16915", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""scoreRange"" class=""form-label"">Score</label>
            <input type=""range"" name=""score"" value=""5"" class=""form-control-range"" min=""0"" max=""10"" step=""1"" id=""score"" onchange=""showSelectedScore()"">
            <span id=""scoreValue"">5</span>
            <br/>
            <label>Your Review</label>
            <textarea class=""form-control"" name=""review""></textarea>
            <input type=""hidden"" id=""review"" name=""review"" />
            <input type=""hidden"" id=""gameId"" name=""gameId""");
                BeginWriteAttribute("value", " value=", 4032, "", 4053, 1);
#nullable restore
#line 79 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
WriteAttributeValue("", 4039, Model.game.Id, 4039, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 80 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
             if (Model.user != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\" id=\"userId\" name=\"userId\"");
                BeginWriteAttribute("value", " value=", 4173, "", 4194, 1);
#nullable restore
#line 82 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
WriteAttributeValue("", 4180, Model.user.Id, 4180, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 83 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <br />\r\n        <div class=\"form-group\">\r\n            <button class=\"btn btn-primary btn-sm\" type=\"submit\"> Post Review </button>\r\n         </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 91 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    window.onload = function onLoad(){\r\n        if(");
#nullable restore
#line 95 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
      Write(Json.Serialize(Model.wishlisted));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"){
            document.getElementById(""heart"").setAttribute(""fill"",""red"");
        }
    }

    function showSelectedScore(){
        document.getElementById(""scoreValue"").innerText = document.getElementById(""score"").value
    }

    function ToggleWishList(){
        var loggedIn = '");
#nullable restore
#line 105 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                    Write(Model.user == null ? "isNull" : "notNull");

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        if(loggedIn==\"isNull\"){\r\n           window.location.href = \"/Identity/Account/Login\";\r\n        }else{\r\n           $.ajax({\r\n               url: \"/Detail/ToggleWishlisted\",\r\n               type: \'POST\',\r\n               data: {wishlisted: ");
#nullable restore
#line 112 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                             Write(Json.Serialize(Model.wishlisted));

#line default
#line hidden
#nullable disable
            WriteLiteral(", userId: \'");
#nullable restore
#line 112 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                                                                          Write(Model.user == null ? "" : Model.user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', gameId: \'");
#nullable restore
#line 112 "D:\WebApps\GameNest\GameNest\Views\Detail\Index.cshtml"
                                                                                                                               Write(Model.game.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'},
               success: function(){
                   window.location.reload();
               },
               error: function(){
                    alert(""Failed to submit review."")
               }
           });
        }
    }
   

   $('#submitReview').submit(function(){
    $.ajax({
        url: ""/Detail/SubmitReview"",
        type: 'POST',
        data : $('#submitReview').serialize(),
        success: function(){
            window.location.reload();
        },
        error: function(){
            alert(""Failed to submit review."")
        }
        });
        return false;
    });
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameNest.ViewModels.DetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
