#pragma checksum "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9282036e0cfba3544cc94e6e088111aeaa735b99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vacunas_Vacuna), @"mvc.1.0.view", @"/Views/Vacunas/Vacuna.cshtml")]
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
#line 1 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\_ViewImports.cshtml"
using Proyecto3IF4101Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\_ViewImports.cshtml"
using Proyecto3IF4101Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9282036e0cfba3544cc94e6e088111aeaa735b99", @"/Views/Vacunas/Vacuna.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f3a760e31f0edcffdee3acedb903f25a5711c1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Vacunas_Vacuna : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proyecto3IF4101Web.Models.VacunasModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formVacuna"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formVacuna"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"
  
    ViewData["Title"] = "Gestion de Vacunas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<h1>");
#nullable restore
#line 9 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9282036e0cfba3544cc94e6e088111aeaa735b995027", async() => {
                WriteLiteral(@"
            <legend class=""text-center"">Registrar Vacunas de Pacientes</legend>


            <div class=""col-12"">
                <label for=""paciente"" class=""form-label"">Cedula de Paciente</label>
                <select class=""form-select form-select mb-3"" name=""cedula"" id=""cedula"" required>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9282036e0cfba3544cc94e6e088111aeaa735b995620", async() => {
                    WriteLiteral("Seleccione una Cédula");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"
                     foreach (Pacientes temp in ViewBag.Pacientes)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9282036e0cfba3544cc94e6e088111aeaa735b997193", async() => {
                    WriteLiteral("\r\n                               ");
#nullable restore
#line 25 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"
                          Write(temp.CEDULA);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" + ");
#nullable restore
#line 25 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"
                                         Write(temp.NOMBRE);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"
                               WriteLiteral(temp.CEDULA);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>

            <div class=""col-12"">
                <label for=""vacuna"" class=""form-label"">Vacuna</label><br />
                <select class=""form-select form-select mb-3"" name=""vacuna"" id=""vacuna"" required>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9282036e0cfba3544cc94e6e088111aeaa735b9910038", async() => {
                    WriteLiteral("Seleccione una Vacuna");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"
                     foreach (Vacunas temp in ViewBag.Vacunas)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9282036e0cfba3544cc94e6e088111aeaa735b9911600", async() => {
                    WriteLiteral("\r\n                            ");
#nullable restore
#line 39 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"
                       Write(temp.NOMBRE);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"
                           WriteLiteral(temp.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\hp\Documents\Github\Proyecto3IF4101\Web\Proyecto3IF4101Web\Views\Vacunas\Vacuna.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    }
                </select>
            </div>

            <div class=""col-12  "">
                <label for=""start"">Descripción:</label>

                <input class=""form-control"" type=""text"" id=""desc"" name=""desc"">

            </div>

            <div class=""col-12 form-group "">
                <label for=""start"">Fecha de Aplicacion:</label>

                <input type=""date"" id=""start"" name=""start"">

                <label for=""start"">Fecha de Proxima Dosis:</label>

                <input type=""date"" id=""end"" name=""end"">

            </div>
            <input type=""submit"" value=""Iniciar sesión"" class=""btn btn-lg btn-primary btn-block"" />
            <div>
                <span id=""resultado""></span>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyecto3IF4101Web.Models.VacunasModel> Html { get; private set; }
    }
}
#pragma warning restore 1591