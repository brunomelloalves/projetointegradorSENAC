#pragma checksum "D:\SENAC\PI_ATV_05\PROJETO_SITE\Views\Home\Produtos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e96e24e0ac1dec2ee30b78a69b4b1004413cfd2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Produtos), @"mvc.1.0.view", @"/Views/Home/Produtos.cshtml")]
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
#line 1 "D:\SENAC\PI_ATV_05\PROJETO_SITE\Views\_ViewImports.cshtml"
using PI_ATV04_Bruno_Mello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SENAC\PI_ATV_05\PROJETO_SITE\Views\_ViewImports.cshtml"
using PI_ATV04_Bruno_Mello.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e96e24e0ac1dec2ee30b78a69b4b1004413cfd2b", @"/Views/Home/Produtos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfd3c7054b0ed70110622edb50377ed35589dd76", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Produtos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e96e24e0ac1dec2ee30b78a69b4b1004413cfd2b3003", async() => {
                WriteLiteral(@"

    <div class=""container col-12"">
        <div class=""row"">
            <div class=""col-sm-3"">
                <h3 id=""texto"">""O que voc?? precisa para o seu evento acontecer!!""</h3>
            </div>
            <div class=""col-sm-3"">
                <p id=""textoProdutos"">
                    ""Temos toda e estrutura que voc?? precisa para seu evento! Desde Palco, Grid, Som e Luz. At??
                    instrumentos.
                    Contamos com m??o de obra qualificada e com o melhor atendimento da regi??o""
                </p>
            </div>

            <div class=""col-sm-6"">
                <div class=""slideshow-container"">

                    <div class=""mySlides fade"">
                        <div class=""numbertext"">1 / 4</div>
                        <img src=""../fotos/mixer.jpg"" id=""imagem"" alt=""MesadeSom"" style=""width: 700px; height: 550px;"" class=""img-fluid"">
                        <div class=""text"">Sonoriza????o</div>
                    </div>

                    ");
                WriteLiteral(@"<div class=""mySlides fade"">
                        <div class=""numbertext"">2 / 4</div>
                        <img src=""../fotos/iluminacao.jpg"" id=""imagem"" alt=""iluminacao""
                            style=""width: 700px; height: 550px;"" class=""img-fluid""> 
                        <div class=""text"">Ilumina????o</div>
                    </div>

                    <div class=""mySlides fade"">
                        <div class=""numbertext"">3 / 4</div>
                        <img src=""../fotos/bateria.jpg"" id=""imagem"" alt=""Bateria"" style=""width: 700px; height: 550px;"" class=""img-fluid"">
                        <div class=""text"">Instrumentos</div>
                    </div>

                    <div class=""mySlides fade"">
                        <div class=""numbertext"">4 / 4/</div>
                        <img src=""../fotos/estrutura.jpg"" id=""imagem"" alt=""Estrutura""
                            style=""width: 700px; height: 550px;"">
                        <div class=""text"">Estruturas</div>
   ");
                WriteLiteral(@"                 </div>


                    <a class=""prev"" onclick=""plusSlides(-1)"">&#10094</a>
                    <a class=""next"" onclick=""plusSlides(1)"">&#10095</a>

                    <div class=""dot-container"">
                        <span class=""dot"" onclick=""currentSlide(1)""></span>
                        <span class=""dot"" onclick=""currentSlide(2)""></span>
                        <span class=""dot"" onclick=""currentSlide(3)""></span>
                        <span class=""dot"" onclick=""currentSlide(4)""></span>
                    </div>
                </div>
            </div>

        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
