#pragma checksum "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff6b9122094c8d45e79b677b818e3828a149e715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detalles), @"mvc.1.0.view", @"/Views/Home/Detalles.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\_ViewImports.cshtml"
using EsteEs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\_ViewImports.cshtml"
using EsteEs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff6b9122094c8d45e79b677b818e3828a149e715", @"/Views/Home/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8f941552cd34095b9de030ef46fbb6f8fc1ad4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EsteEs.ViewModels.DetallesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded mx-auto d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff6b9122094c8d45e79b677b818e3828a149e7154146", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 247, "~/", 247, 2, true);
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
AddHtmlAttributeValue("", 249, Model.integrante.Imagen, 249, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"border-card\">\r\n    <div class=\"content-wrapper\">\r\n        <div class=\"label-group\">\r\n            <h3>Datos Personales</h3>\r\n            <p class=\"title\">Sexo: ");
#nullable restore
#line 13 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                              Write(Html.DisplayFor(ModelItem => Model.integrante.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"min-gap\"></div>\r\n        <div class=\"label-group\">\r\n            <p class=\"title\">Nombre: ");
#nullable restore
#line 17 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                Write(Html.DisplayFor(ModelItem => Model.integrante.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n        <div class=\"min-gap\"></div>\r\n        <div class=\"label-group\">\r\n            <p class=\"title\">Apellido :");
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                  Write(Html.DisplayFor(ModelItem => Model.integrante.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"min-gap\"></div>\r\n    <div class=\"label-group\">\r\n        <p class=\"title\">Fecha de Nacimiento :");
#nullable restore
#line 28 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                         Write(Html.DisplayFor(ModelItem => Model.integrante.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Pais de Nacimiento :");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                    Write(Html.DisplayFor(ModelItem => Model.integrante.PaisNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Cuidad de Nacimiento :");
#nullable restore
#line 38 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                      Write(Html.DisplayFor(ModelItem => Model.integrante.CiudadNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n<div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Pais de Residencia Actual :");
#nullable restore
#line 44 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                           Write(Html.DisplayFor(ModelItem => Model.integrante.PaisResidencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n<div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Ciudad de Residencia Actual :");
#nullable restore
#line 49 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                             Write(Html.DisplayFor(ModelItem => Model.integrante.CiudadResidencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n<div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Telefono :");
#nullable restore
#line 55 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                          Write(Html.DisplayFor(ModelItem => Model.integrante.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n<div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Direccion :");
#nullable restore
#line 60 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                           Write(Html.DisplayFor(ModelItem => Model.integrante.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div><div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Celular :");
#nullable restore
#line 64 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                         Write(Html.DisplayFor(ModelItem => Model.integrante.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n<div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">correo electronico :");
#nullable restore
#line 69 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                    Write(Html.DisplayFor(ModelItem => Model.integrante.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n<div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Tipo de Documento de Identidad :");
#nullable restore
#line 74 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                Write(Html.DisplayFor(ModelItem => Model.integrante.TipoDocIdentidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n<div class=\"min-gap\"></div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Documento de identidad :");
#nullable restore
#line 80 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                        Write(Html.DisplayFor(ModelItem => Model.integrante.DocIdentidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n\r\n<h3>Datos Familiares</h3>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Estado Civil : ");
#nullable restore
#line 87 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                               Write(Html.DisplayFor(ModelItem => Model.datofam.EstadoCivil));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Hijos : ");
#nullable restore
#line 92 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                        Write(Html.DisplayFor(ModelItem => Model.datofam.Hijos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n<h3>Datos Laborales</h3>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Profesion : ");
#nullable restore
#line 98 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                            Write(Html.DisplayFor(ModelItem => Model.datolab.Profesion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Nombre Empresa : ");
#nullable restore
#line 103 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                 Write(Html.DisplayFor(ModelItem => Model.datolab.NombreEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Ocupacion : ");
#nullable restore
#line 107 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                            Write(Html.DisplayFor(ModelItem => Model.datolab.Ocupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Telefono : ");
#nullable restore
#line 112 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                           Write(Html.DisplayFor(ModelItem => Model.datolab.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n\r\n<h3>Datos Academicos</h3>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Nivel de Estudio : ");
#nullable restore
#line 119 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                   Write(Html.DisplayFor(ModelItem => Model.datoac.NivelEstudio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Razones de Expulsion anteriores: ");
#nullable restore
#line 124 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                 Write(Html.DisplayFor(ModelItem => Model.datoac.Expulsado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n<h3>Datos Eclesiasticos</h3>\r\n\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Fecha de Conversion: ");
#nullable restore
#line 131 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                     Write(Html.DisplayFor(ModelItem => Model.datoecl.FechaConversion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Fecha de Bautismo: ");
#nullable restore
#line 135 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                   Write(Html.DisplayFor(ModelItem => Model.datoecl.FechaBautismo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Fecha en que\tfue\taceptado(a)\tformalmente\tcomo miembro de la Iglesia: ");
#nullable restore
#line 140 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                                                                 Write(Html.DisplayFor(ModelItem => Model.datoecl.FechaAceptado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Denominacion a la que pertenece: ");
#nullable restore
#line 144 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                 Write(Html.DisplayFor(ModelItem => Model.datoecl.Denominacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Nombre de la iglesia a la que asiste actualmente: ");
#nullable restore
#line 147 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                                  Write(Html.DisplayFor(ModelItem => Model.datoecl.NombreIglesia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Congregacion anterior a esta: ");
#nullable restore
#line 150 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                              Write(Html.DisplayFor(ModelItem => Model.datoecl.CongregacionAnterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Nombre del pastor de su iglesia actual: ");
#nullable restore
#line 153 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                        Write(Html.DisplayFor(ModelItem => Model.datoecl.Pastor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Numero de veces Disciplinado: ");
#nullable restore
#line 156 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                              Write(Html.DisplayFor(ModelItem => Model.datoecl.Disciplinado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Causas de la disciplinacion: ");
#nullable restore
#line 159 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                             Write(Html.DisplayFor(ModelItem => Model.datoecl.DisciplinadoCausas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Funcion que Ejerce actualmente: ");
#nullable restore
#line 162 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                Write(Html.DisplayFor(ModelItem => Model.datoecl.Funciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Ministerios a los que ha servido: ");
#nullable restore
#line 165 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                  Write(Html.DisplayFor(ModelItem => Model.datoecl.Ministerios));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Ministerio donde tuvo mayor fruto: ");
#nullable restore
#line 168 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                   Write(Html.DisplayFor(ModelItem => Model.datoecl.MinisteriosMayorFruto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">A que ministerio cree que Dios lo llama ");
#nullable restore
#line 171 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                        Write(Html.DisplayFor(ModelItem => Model.datoecl.MinisteriosLlamado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Metas en su vida: ");
#nullable restore
#line 174 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                  Write(Html.DisplayFor(ModelItem => Model.datoecl.Metas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"label-group\">\r\n    <p class=\"title\">Cuenta Con Respaldo de sus autoridades Eclesiasticas: ");
#nullable restore
#line 178 "C:\Users\Usuario\source\repos\EsteEs\EsteEs\Views\Home\Detalles.cshtml"
                                                                      Write(Html.DisplayFor(ModelItem => Model.datoecl.Respaldo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsteEs.ViewModels.DetallesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591