#pragma checksum "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f4a4fdd02f7d9866806721f30f8c85dcfb9425b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
#line 1 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\_ViewImports.cshtml"
using FicticiaSeguros;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\_ViewImports.cshtml"
using FicticiaSeguros.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4a4fdd02f7d9866806721f30f8c85dcfb9425b", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c6f66a0136ad8f02b76d078429699a8308635e", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<FicticiaSeguros.Core.DTOs.PersonsDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
  
    ViewData["Title"] = "Listado";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"text-center\" >Listado de Asegurados</h4>\r\n\r\n<hr />\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row justify-content-md-center\">\r\n        \r\n        <div class=\"col col-md-auto\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f4a4fdd02f7d9866806721f30f8c85dcfb9425b7676", async() => {
                WriteLiteral("Alta Persona");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col col-md-auto\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f4a4fdd02f7d9866806721f30f8c85dcfb9425b8997", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n\r\n                   Buscar por Nombre: <input type=\"text\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 722, "\"", 756, 1);
#nullable restore
#line 28 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
WriteAttributeValue("", 730, ViewData["CurrentFilter"], 730, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Buscar\" class=\"btn btn-sm btn-success\" /> | ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f4a4fdd02f7d9866806721f30f8c85dcfb9425b9893", async() => {
                    WriteLiteral(" Volver a Listado ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("| Cant. Items:\r\n\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        
        <div class=""col col-md-auto"">
            <div class=""row"">
                
                
                <select style=""width: auto !important; margin-right: 1rem"" name=""PageSize"" id=""PageSize"" class=""form-control"">
                    <");
            WriteLiteral("option ");
#nullable restore
#line 40 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                              if ((int)ViewBag.PageSize == 10) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                            Write(Html.Raw("selected"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"10\">10</");
            WriteLiteral("option>\r\n                    <");
            WriteLiteral("option ");
#nullable restore
#line 41 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                              if ((int)ViewBag.PageSize == 25) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                            Write(Html.Raw("selected"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"25\">25</");
            WriteLiteral("option>\r\n                    <");
            WriteLiteral("option ");
#nullable restore
#line 42 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                              if ((int)ViewBag.PageSize == 50) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                            Write(Html.Raw("selected"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"50\">50</");
            WriteLiteral("option>\r\n                    <");
            WriteLiteral("option ");
#nullable restore
#line 43 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                              if ((int)ViewBag.PageSize == 100) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                             Write(Html.Raw("selected"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"100\">100</");
            WriteLiteral(@"option>
                </select>

                <input type=""submit"" value=""Aplicar"" class=""btn btn-sm btn-primary"" />

            </div>
        </div>
    </div>
</div>




<table class=""table table-hover"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 60 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
           Write(Html.ActionLink("Nombre", "Index", new { sortOrder = ViewBag.NameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Identificación\r\n            </th>\r\n            <th>\r\n                Edad\r\n            </th>\r\n            <th>\r\n                Estado\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 72 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
           Write(Html.ActionLink("Fecha Alta", "Index", new { sortOrder = ViewBag.DateSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Acciones\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 80 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 84 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 93 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                     if (!item.State)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       ");
            WriteLiteral("Inactivo\r\n");
#nullable restore
#line 96 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("Activo\r\n");
#nullable restore
#line 100 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 103 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f4a4fdd02f7d9866806721f30f8c85dcfb9425b20529", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f4a4fdd02f7d9866806721f30f8c85dcfb9425b22836", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f4a4fdd02f7d9866806721f30f8c85dcfb9425b25150", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 111 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<hr/>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row justify-content-md-center\">\r\n        <div class=\"col col-md-2\" align=\"left\">\r\n            Pagina ");
#nullable restore
#line 120 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
               Write( Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber );

#line default
#line hidden
#nullable disable
            WriteLiteral(" de ");
#nullable restore
#line 120 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                                                                                Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-auto\">\r\n            ");
#nullable restore
#line 123 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", "Person", new { page, pageSize = ViewBag.PageSize })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col col-md-2\" align=\"right\">\r\n            Items totales ");
#nullable restore
#line 126 "C:\Users\Mauro\Documents\Visual Studio 2019\Proyectos\FicticiaSeguros\Views\Person\Index.cshtml"
                     Write(Model.TotalItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<FicticiaSeguros.Core.DTOs.PersonsDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591