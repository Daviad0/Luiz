#pragma checksum "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/Home/Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dfaef4d0bf0c02469ba82d52b8f686bc99f1e33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Master), @"mvc.1.0.view", @"/Views/Home/Master.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Master.cshtml", typeof(AspNetCore.Views_Home_Master))]
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
#line 1 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/_ViewImports.cshtml"
using LuizApp;

#line default
#line hidden
#line 2 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/_ViewImports.cshtml"
using LuizApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dfaef4d0bf0c02469ba82d52b8f686bc99f1e33", @"/Views/Home/Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"439698069bbdf602bab9e3246ba330095c6c95da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/Home/Master.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 1812, true);
            WriteLiteral(@"<style>
    .*{
        margin:0px;
    }
    .answerbutton{
        width:100%;
        height:100%;
        font-size:200px;
        font-weight:900;
        color:white;
        border:0px solid #EEEEEE
    }
    .answerbutton:hover{
        filter: brightness(85%);
    }
    .answerbutton:active{
        filter: brightness(60%);
    }
    .fullscreendiv{
        background-color:#EEEEEE;
        padding:30px;
        display:none;
    }
    .fullscreendiv:fullscreen{
        display:inline;
    }
    .smallstatusicons {
        height: 50px;
        width: 50px;
        background-color:lightblue;
        border-radius: 50%;
        display: inline-block;
        border:4px solid gray
    }

</style>
<div id=""questionp"">
    <input type=""button"" id=""checkanswer1"" value=""Check Answer 1"" />
    <input type=""button"" id=""checkanswer2"" value=""Check Answer 2"" />
    <input type=""button"" id=""checkanswer3"" value=""Check Answer 3"" />
    <input type=""button"" id=""checkanswer4""");
            WriteLiteral(@" value=""Check Answer 4"" />
</div>
<div id=""resultsp"" style=""display:none"">
    <span id=""num1"" style=""background-color:black;padding:5px;color:white"">0</span>
    <span id=""num2"" style=""background-color:black;padding:5px;color:white"">0</span>
    <span id=""num3"" style=""background-color:black;padding:5px;color:white"">0</span>
    <span id=""num4"" style=""background-color:black;padding:5px;color:white"">0</span>
    <span id=""numcorrect"" style=""background-color:green;padding:5px;color:white"">0</span>
    <span id=""numwrong"" style=""background-color:red;padding:5px;color:white"">0</span>
    <input type=""button"" id=""leaderboard"" value=""Leaderboard"" />
</div>
<div id=""leaderboardp""  style=""display:none"">
    <input type=""button"" id=""next"" value=""Next Question"" />
</div>

");
            EndContext();
            BeginContext(1855, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e9ba9049694714bd51894e154ccc2b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1916, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1918, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b531c6a3fe04650914dfdf3d742638d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1969, 3039, true);
            WriteLiteral(@"
<script>
    $('#toggle_fullscreen').on('click', function () {
        // if already full screen; exit
        // else go fullscreen
        if (
            document.fullscreenElement ||
            document.webkitFullscreenElement ||
            document.mozFullScreenElement ||
            document.msFullscreenElement
        ) {
            if (document.exitFullscreen) {
                document.exitFullscreen();
            } else if (document.mozCancelFullScreen) {
                document.mozCancelFullScreen();
            } else if (document.webkitExitFullscreen) {
                document.webkitExitFullscreen();
            } else if (document.msExitFullscreen) {
                document.msExitFullscreen();
            }
        } else {
            element = $('#fullscreenthis').get(0);
            if (element.requestFullscreen) {
                element.requestFullscreen();
            } else if (element.mozRequestFullScreen) {
                element.mozRequestFullScreen();
            } else if");
            WriteLiteral(@" (element.webkitRequestFullscreen) {
                element.webkitRequestFullscreen(Element.ALLOW_KEYBOARD_INPUT);
            } else if (element.msRequestFullscreen) {
                element.msRequestFullscreen();
            }
            
        }
    });
</script>
<script>
    var quiz = new signalR.HubConnectionBuilder().withUrl(""/quizHub"").build();
    quiz.on(""questionResults"", function (Correct, Wrong, Num1, Num2, Num3, Num4) {
        $(""#numcorrect"").html(Correct);
        $(""#numwrong"").html(Wrong);
        $(""#num1"").html(Num1);
        $(""#num2"").html(Num2);
        $(""#num3"").html(Num3);
        $(""#num4"").html(Num4);
    });
    quiz.start().then(function () {
        $(""#checkanswer1"").click(function () {
            ShowResults(1);
        });
        $(""#checkanswer2"").click(function () {
            ShowResults(2);
        });
        $(""#checkanswer3"").click(function () {
            ShowResults(3);
        });
        $(""#checkanswer4"").click(function () {
            S");
            WriteLiteral(@"howResults(4);
        });
        $(""#next"").click(function () {
            ShowQuestion();
        });
        $(""#leaderboard"").click(function () {
            ShowLeaderboard();
        });
        function ShowQuestion() {
            $(""#questionp"").css(""display"", ""inline"");
            $(""#resultsp"").css(""display"", ""none"");
            $(""#leaderboardp"").css(""display"", ""none"");
        }
        function ShowResults(CorrectAnswer) {
            quiz.invoke(""nextQuestion"");
            quiz.invoke(""checkAnswers"", CorrectAnswer);
            quiz.invoke(""viewToggle"", true);
            $(""#questionp"").css(""display"", ""none"");
            $(""#resultsp"").css(""display"", ""inline"");
            $(""#leaderboardp"").css(""display"", ""none"");
        }
        function ShowLeaderboard() {
            $(""#questionp"").css(""display"", ""none"");
            $(""#resultsp"").css(""display"", ""none"");
            $(""#leaderboardp"").css(""display"", ""inline"");
        }
    });
    
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
