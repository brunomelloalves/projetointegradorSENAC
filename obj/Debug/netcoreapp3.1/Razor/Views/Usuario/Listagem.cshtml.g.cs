#pragma checksum "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918f1cd7165415e88a2e9eb2c5ad01832770e63f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
#line 1 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\_ViewImports.cshtml"
using PI_ATV04_Bruno_Mello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\_ViewImports.cshtml"
using PI_ATV04_Bruno_Mello.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"918f1cd7165415e88a2e9eb2c5ad01832770e63f", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfd3c7054b0ed70110622edb50377ed35589dd76", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""bg"">
    <img src=""..\fotos\bsoundlogo.png"" id=""logo"">
    <div class=""container"">
        <h4>""O que você precisa para o seu evento acontecer!!""</h4>
    </div>

<table class=""table"">
    <tr>
        <td>ID</td>
        <td>Nome</td>
        <td>Telefone</td>
        <td>Email</td>
        <td>Login</td>
        <td>Senha</td>

    </tr>

");
#nullable restore
#line 23 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
     foreach (Usuario u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
           Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
           Write(u.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
           Write(u.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
           Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
           Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 732, "\"", 763, 2);
            WriteAttributeValue("", 739, "/Usuario/Editar?Id=", 739, 19, true);
#nullable restore
#line 33 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 758, u.Id, 758, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 796, "\"", 828, 2);
            WriteAttributeValue("", 803, "/Usuario/Excluir?Id=", 803, 20, true);
#nullable restore
#line 34 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 823, u.Id, 823, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Deseja excluir esse item?\');\">Remover</a>\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "D:\SENAC\PROJETO INTEGRADOR\PI_ATV04_Bruno_Mello\Views\Usuario\Listagem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591