#pragma checksum "C:\Users\djree\source\repos\Luiz\LuizApp\LuizApp\Views\Home\Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "901bd34ff51f11608a41763b804c663b44c3d5a4"
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
#line 1 "C:\Users\djree\source\repos\Luiz\LuizApp\LuizApp\Views\_ViewImports.cshtml"
using LuizApp;

#line default
#line hidden
#line 2 "C:\Users\djree\source\repos\Luiz\LuizApp\LuizApp\Views\_ViewImports.cshtml"
using LuizApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"901bd34ff51f11608a41763b804c663b44c3d5a4", @"/Views/Home/Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e24ec20d155bf4a7d8815432c69aa798990b8eb", @"/Views/_ViewImports.cshtml")]
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
#line 1 "C:\Users\djree\source\repos\Luiz\LuizApp\LuizApp\Views\Home\Master.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 13474, true);
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
    .rank1leaderboard {
        background: rgb(0,2,177);
        background: linear-gradient(145deg, rgba(0,2,177,1) 0%, rgba(0,191,255,1) 100%);
    }
    .rank23leaderboard {
        background: rgb(0,191,255);
    }
    .rank4567leaderboard {
        background: rgb(0,191,2");
            WriteLiteral(@"55);
    }
</style>
<nav class=""navbar navbar-inverse navbar-fixed-top"" style=""background-color:#03b1fc;border:none"">
    <div class=""container"" style=""text-align:center"">
        <span style=""font-weight:800;text-align:left;color:white;padding:10px;font-size:40px;float:left"">Luiz</span>
        
    </div>
</nav>
<div style=""margin-top:20px"">
    <div id=""loginscreen"" style=""text-align:center"">
        <div style=""background-color:#03b1fc;font-size:60px;font-weight:600;padding:10px;border-radius:10px;color:white;display:flex;justify-content:space-between"">
            <div>
                Game Key: <br /><span id=""gamecode"" style=""color:#03b1fc;background-color:white;padding:10px;border-radius:8px;font-size:90px"">[UNAVAIL]</span><span id=""gameerror"" style=""margin-left:10px"">&#9888;</span>
            </div>
            <div>
                Contestants: <br /><span id=""numplayers"" style=""color:#00ed7a;background-color:white;padding:10px;border-radius:8px;font-size:90px"">0</span>
           ");
            WriteLiteral(@" </div>
        </div>
    </div>
    <div id=""questionp"" style=""display:none"">
        <br />
        <br />
        <table style=""position: absolute; top: 8vh; bottom: 0; left: 0; right: 0;width:100%"">
            <tr>
                <td style=""width:10%;overflow:hidden;background-color:white;border:4px solid lightgray;border-radius:6px 0px 0px 6px"">
                    <span style=""font-weight:900;font-size:50px;text-align:center;margin-left:40px;color:gray"">Q</span>
                </td>
                <td style=""width:90%;text-wrap:inherit;padding:30px;background-color:lightgray;border:4px solid lightgray;border-radius:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"">What is 1 + 1?</span>
                </td>
            </tr>
        </table>
        <table style=""width:100%;border-spacing:0 15px;border-collapse:separate;margin-top:15vh"">
            
            <tr>
                <");
            WriteLiteral(@"td style=""width:10%;overflow:hidden;background-color:white;border:4px solid #42c5f5;border-radius:6px 0px 0px 6px"">
                    <span style=""font-weight:900;font-size:50px;text-align:center;margin-left:40px;color:#42c5f5"">1</span>
                </td>
                <td style=""width:90%;text-wrap:inherit;padding:30px;background-color:#42c5f5;border:4px solid #42c5f5;border-radius:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"">1</span>
                </td>
            </tr>
            <tr>
                <td style=""width:10%;overflow:hidden;background-color:white;border:4px solid #f54284;border-radius:6px 0px 0px 6px"">
                    <span style=""font-weight:900;font-size:50px;text-align:center;margin-left:40px;color:#f54284"">2</span>
                </td>
                <td style=""width:90%;text-wrap:inherit;padding:30px;background-color:#f54284;border:4px solid #f54284;border-radi");
            WriteLiteral(@"us:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"">2</span>
                </td>
            </tr>
            <tr>
                <td style=""width:10%;overflow:hidden;background-color:white;border:4px solid #3ce663;border-radius:6px 0px 0px 6px"">
                    <span style=""font-weight:900;font-size:50px;text-align:center;margin-left:40px;color:#3ce663"">3</span>
                </td>
                <td style=""width:90%;text-wrap:inherit;padding:30px;background-color:#3ce663;border:4px solid #3ce663;border-radius:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"">5</span>
                </td>
            </tr>
            <tr>
                <td style=""width:10%;overflow:hidden;background-color:white;border:4px solid #e6c73c;border-radius:6px 0px 0px 6px"">
                    <span style=""font-");
            WriteLiteral(@"weight:900;font-size:50px;text-align:center;margin-left:40px;color:#e6c73c"">4</span>
                </td>
                <td style=""width:90%;text-wrap:inherit;padding:30px;background-color:#e6c73c;border:4px solid #e6c73c;border-radius:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"">The answer is triangle!</span>
                </td>
            </tr>
        </table>
        <table width=""100%"">
            <tr>
                <td style=""width:25%"">
                    <input id=""checkanswer1"" value=""Check #1"" type=""button""/>
                </td>
                <td style=""width:25%"">
                    <input id=""checkanswer2"" value=""Check #2"" type=""button""/>
                </td>
                <td style=""width:25%"">
                    <input id=""checkanswer3"" value=""Check #3"" type=""button""/>
                </td>
                <td style=""width:25%"">
                    <input id");
            WriteLiteral(@"=""checkanswer4"" value=""Check #4"" type=""button""/>
                </td>
            </tr>
        </table>
    </div>
    <div id=""resultsp"" style=""display:none"">
        <table style=""width:100%;text-align:center;border-spacing:0 15px;border-collapse:separate"">
            <tr>
                <td style=""width:10%;color:#42c5f5"">
                    <span id=""num1l"" style=""font-weight:900;font-size:50px;text-align:center"">1</span>
                </td>
                <td id=""num1c"" style=""width:90%;background-color:#42c5f5;color:white;border-radius:8px"">
                    <span id=""num1"" style=""font-weight:700;font-size:40px;text-align:center;padding-top:0vh"">0</span>
                </td>
                <td id=""num1w"" style=""width:0%;background-color:white;color:white"">
                    <span style=""font-weight:700;font-size:40px;text-align:center;padding-top:0vh""></span>
                </td>
                
            </tr>
            </table>
        <table style=""width:100%;");
            WriteLiteral(@"text-align:center;border-spacing:0 15px;border-collapse:separate"">
            <tr>
                
                <td style=""width:10%;color:#f54284"">
                    <span id=""num2l"" style=""font-weight:900;font-size:50px;text-align:center"">2</span>
                </td>
                <td id=""num2c"" style=""width:90%;background-color:#f54284;color:white;border-radius:8px"">
                    <span id=""num2"" style=""font-weight:700;font-size:40px;text-align:center;padding-top:0vh"">0</span>
                </td>
                <td id=""num2w"" style=""width:0%;background-color:white;color:white"">
                    <span style=""font-weight:900;font-size:40px;text-align:center;padding-top:0vh""></span>
                </td>
                
            </tr>
            </table>
        <table style=""width:100%;text-align:center;border-spacing:0 15px;border-collapse:separate"">
            <tr>
                <td style=""width:10%;color:#3ce663"">
                    <span id=""num3l"" style=");
            WriteLiteral(@"""font-weight:900;font-size:50px;text-align:center"">3</span>
                </td>
                <td id=""num3c"" style=""width:90%;background-color:#3ce663;color:white;border-radius:8px"">
                    <span id=""num3"" style=""font-weight:700;font-size:40px;text-align:center;padding-top:0vh"">0</span>
                </td>
                <td id=""num3w"" style=""width:0%;background-color:white;color:white"">
                    <span style=""font-weight:900;font-size:40px;text-align:center;padding-top:0vh""></span>
                </td>
            </tr>
            </table>
        <table style=""width:100%;text-align:center;border-spacing:0 15px;border-collapse:separate"">
            <tr>
                <td style=""width:10%;color:#e6c73c"">
                    <span id=""num4l"" style=""font-weight:900;font-size:50px;text-align:center"">4</span>
                </td>
                <td id=""num4c"" style=""width:90%;background-color:#e6c73c;color:white;border-radius:8px"">
                    <span id=");
            WriteLiteral(@"""num4"" style=""font-weight:700;font-size:40px;text-align:center;padding-top:0vh"">0</span>
                </td>
                <td id=""num4w"" style=""width:0%;background-color:white;color:white"">
                    <span style=""font-weight:900;font-size:40px;text-align:center;padding-top:0vh""></span>
                </td>
            </tr>
        </table>
        <span id=""num1"" style=""background-color:black;padding:5px;color:white"">0</span>
        <span id=""num2"" style=""background-color:black;padding:5px;color:white"">0</span>
        <span id=""num3"" style=""background-color:black;padding:5px;color:white"">0</span>
        <span id=""num4"" style=""background-color:black;padding:5px;color:white"">0</span>
        <span id=""numcorrect"" style=""background-color:green;padding:5px;color:white"">0</span>
        <span id=""numwrong"" style=""background-color:red;padding:5px;color:white"">0</span>
        <input type=""button"" id=""leaderboard"" value=""Leaderboard"" />
    </div>
    <div id=""leaderboardp""  style=");
            WriteLiteral(@"""display:none;text-align:center"">
        <br />
        <br />
        <div class=""rank23leaderboard"" style=""border-radius:10px;padding:15px;display:flex;justify-content:space-between"">
            <span style=""font-size:30px;color:white;font-weight:600"">1</span>
            <span style=""font-size:30px;color:white;font-weight:600"">Daviado</span>
            <span style=""font-size:30px;color:white;font-weight:600;border-radius:4px;vertical-align:middle"">2000</span>
        </div>
        <br />
        <div class=""rank23leaderboard"" style=""border-radius:10px;padding:15px;display:flex;justify-content:space-between"">
            <span style=""font-size:30px;color:white;font-weight:600"">2</span>
            <span style=""font-size:30px;color:white;font-weight:600"">Daviado</span>
            <span style=""font-size:30px;color:white;font-weight:600;border-radius:4px;vertical-align:middle"">1999</span>
        </div>
        <br />
        <div class=""rank23leaderboard"" style=""border-radius:10px;padding:");
            WriteLiteral(@"15px;display:flex;justify-content:space-between"">
            <span style=""font-size:30px;color:white;font-weight:600"">3</span>
            <span style=""font-size:30px;color:white;font-weight:600"">Daviado</span>
            <span style=""font-size:30px;color:white;font-weight:600;border-radius:4px;vertical-align:middle"">1998</span>
        </div>
        <br />
        <div class=""rank23leaderboard"" style=""border-radius:10px;padding:15px;display:flex;justify-content:space-between"">
            <span style=""font-size:30px;color:white;font-weight:600"">4</span>
            <span style=""font-size:30px;color:white;font-weight:600"">Daviado</span>
            <span style=""font-size:30px;color:white;font-weight:600;border-radius:4px;vertical-align:middle"">1997</span>
        </div>
        <br />
        <div class=""rank23leaderboard"" style=""border-radius:10px;padding:15px;display:flex;justify-content:space-between"">
            <span style=""font-size:30px;color:white;font-weight:600"">5</span>
          ");
            WriteLiteral(@"  <span style=""font-size:30px;color:white;font-weight:600"">Daviado</span>
            <span style=""font-size:30px;color:white;font-weight:600;border-radius:4px;vertical-align:middle"">1996</span>
        </div>
        <br />
        <div class=""rank23leaderboard"" style=""border-radius:10px;padding:15px;display:flex;justify-content:space-between"">
            <span style=""font-size:30px;color:white;font-weight:600"">6</span>
            <span style=""font-size:30px;color:white;font-weight:600"">Daviado</span>
            <span style=""font-size:30px;color:white;font-weight:600;border-radius:4px;vertical-align:middle"">1995</span>
        </div>
        <br />
        <div class=""rank23leaderboard"" style=""border-radius:10px;padding:15px;display:flex;justify-content:space-between"">
            <span style=""font-size:30px;color:white;font-weight:600"">7</span>
            <span style=""font-size:30px;color:white;font-weight:600"">Daviado</span>
            <span style=""font-size:30px;color:white;font-weight:6");
            WriteLiteral("00;border-radius:4px;vertical-align:middle\">1994</span>\r\n        </div>\r\n        <input type=\"button\" id=\"next\" value=\"Next Question\" />\r\n    </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(13517, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb376f9d948d4141b041d4e1c49e2c27", async() => {
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
            BeginContext(13578, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(13580, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e58c58f11504a16b2fc4a3a0dd55192", async() => {
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
            BeginContext(13631, 5919, true);
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
    var GameKey = 0;
    var CurrentCorrect = 0;
    var quiz = new signalR.HubConnectionBuilder().withUrl(""/quizHub"").build();
    
    quiz.on(""questionResults"", function (Correct, Wrong, Num1, Num2, Num3, Num4) {
        $(""#numcorrect"").html(Correct);
        $(""#numwrong"").html(Wrong);
        $(""#num1"").html(Num1);
        $(""#num2"").html(Num2);
        $(""#num3"").html(Num3);
        $(""#num4"").html(Num4);
        var totalanswers = Num1 + Num2 + Num3 + Num4
        if (totalanswers == 0) {
            totalanswers = 1
        }
        num1percent = ((Num1 / totalanswers)*90)
        num2percent = ((Num2 / totalanswers)*90)
        num3percent = ((Num3 / totalanswers)*90)
        num4percent = ((Num4 / tot");
            WriteLiteral(@"alanswers) * 90)
        $(""#num1c"").css(""width"", num1percent + ""%"")
        $(""#num2c"").css(""width"", num2percent + ""%"")
        $(""#num3c"").css(""width"", num3percent + ""%"")
        $(""#num4c"").css(""width"", num4percent + ""%"")
        $(""#num1w"").css(""width"", (90-num1percent) + ""%"")
        $(""#num2w"").css(""width"", (90-num2percent) + ""%"")
        $(""#num3w"").css(""width"", (90-num3percent) + ""%"")
        $(""#num4w"").css(""width"", (90 - num4percent) + ""%"")
        $(""#num1c"").css(""background-color"", ""gray"")
        $(""#num2c"").css(""background-color"", ""gray"")
        $(""#num3c"").css(""background-color"", ""gray"")
        $(""#num4c"").css(""background-color"", ""gray"")
        $(""#num1l"").css(""color"", ""gray"")
        $(""#num2l"").css(""color"", ""gray"")
        $(""#num3l"").css(""color"", ""gray"")
        $(""#num4l"").css(""color"", ""gray"")
        $(""#num"" + CurrentCorrect + ""c"").css(""background-color"", ""green"")
        $(""#num"" + CurrentCorrect + ""l"").css(""color"", ""green"")

    });
    quiz.on(""sendLeaderboard"",");
            WriteLiteral(@" function (TopTen) {
        $(""#userleaderboard"").empty();
        $.each(TopTen, function (index, value) {
                /*var markup = ""<tr style='text-align:center;background-color:red'><td width='30%' style='text-align:center'>"" +
                    value.userName + ""</td><td style='background-color:black;color:white;padding:5px;font-size:30px;font-weight:600;border-radius:4px 0px 0px 4px'>"" +
                        value.points + ""</td><td style='background-color:#03b1fc;color:white;padding:5px;font-size:30px;font-weight:600;border-radius:0px 4px 4px 0px'>"" +
                        value.streak + ""</td></tr>"";
                $(""#userleaderboard"").append(markup);*/
            });
    });
    quiz.start().then(function () {
        $(document).ready(function () {
            GameKey = Math.floor((Math.random() * 1000000) + 1);
            quiz.invoke(""instanceCreate"", GameKey);
        });
        $(""#checkanswer1"").click(function () {
            ShowResults(1);
        });
        $(""#c");
            WriteLiteral(@"heckanswer2"").click(function () {
            ShowResults(2);
        });
        $(""#checkanswer3"").click(function () {
            ShowResults(3);
        });
        $(""#checkanswer4"").click(function () {
            ShowResults(4);
        });
        $(""#next"").click(function () {
            ShowQuestion();
        });
        $(""#leaderboard"").click(function () {
            ShowLeaderboard();
        });
        quiz.on(""gameCreated"", function (Successful, GameKeySent) {
            if (!Successful) {
                GameKey = Math.floor((Math.random() * 1000000) + 1);
                quiz.invoke(""instanceCreate"", GameKey);
                $(""#gameerror"").css(""background-color"", ""red"")
            } else {
                $(""#gamecode"").html(GameKeySent)
                $(""#gameerror"").css(""display"",""none"")
            }
        });
        function ShowQuestion() {
            $(""#questionp"").css(""display"", ""inline"");
            $(""#resultsp"").css(""display"", ""none"");
            $(""#leaderboard");
            WriteLiteral(@"p"").css(""display"", ""none"");
            quiz.invoke(""nextQuestion"");
        }
        function ShowResults(CorrectAnswer) {
            quiz.invoke(""nextQuestion"");
            quiz.invoke(""checkAnswers"", CorrectAnswer);
            quiz.invoke(""viewToggle"", true);
            CurrentCorrect = CorrectAnswer;
            $(""#questionp"").css(""display"", ""none"");
            $(""#resultsp"").css(""display"", ""inline"");
            $(""#leaderboardp"").css(""display"", ""none"");
        }
        function ShowLeaderboard() {
            $(""#questionp"").css(""display"", ""none"");
            $(""#resultsp"").css(""display"", ""none"");
            $(""#leaderboardp"").css(""display"", ""inline"");
            quiz.invoke(""getLeaderboard"");
        }
        function Countdown() {

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
