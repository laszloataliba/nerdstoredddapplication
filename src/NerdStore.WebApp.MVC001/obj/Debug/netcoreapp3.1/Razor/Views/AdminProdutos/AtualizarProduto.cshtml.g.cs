#pragma checksum "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\AtualizarProduto.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "428ddbec7dea883263f82e75269c7b74bf3d7dde7a373e6e8988d499497c9661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_AdminProdutos_AtualizarProduto), @"mvc.1.0.view", @"/Views/AdminProdutos/AtualizarProduto.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"428ddbec7dea883263f82e75269c7b74bf3d7dde7a373e6e8988d499497c9661", @"/Views/AdminProdutos/AtualizarProduto.cshtml")]
    #nullable restore
    internal sealed class Views_AdminProdutos_AtualizarProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\AtualizarProduto.cshtml"
       NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\AtualizarProduto.cshtml"
  
    ViewData["Title"] = "AtualizarProduto";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<h1>Editar Produto</h1>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""AtualizarProduto"">
            <div asp-validation-summary=""All"" class=""text-danger""></div>

            <input type=""hidden"" asp-for=""Id"" />

            <div class=""form-group"">
                <label class=""control-label"">Categoria</label>
                <select asp-for=""CategoriaId"" class=""form-control""");
            BeginWriteAttribute("asp-items", " asp-items=\"", 545, "\"", 606, 1);
            WriteAttributeValue("", 557, 
#nullable restore
#line 18 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\AtualizarProduto.cshtml"
                                                                                new SelectList(Model.Categorias, "Id", "Nome")

#line default
#line hidden
#nullable disable
            , 557, 49, false);
            EndWriteAttribute();
            WriteLiteral(@">
                    <option></option>
                </select>

                <span asp-validation-for=""CategoriaId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Descricao"" class=""control-label""></label>
                <input asp-for=""Descricao"" class=""form-control"" />
                <span asp-validation-for=""Descricao"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""Ativo"" /> ");
            Write(
#nullable restore
#line 36 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\AtualizarProduto.cshtml"
                                                                        Html.DisplayNameFor(model => model.Ativo)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""Valor"" class=""control-label""></label>
                <input asp-for=""Valor"" class=""form-control"" />
                <span asp-validation-for=""Valor"" class=""text-danger""></span>
            </div>

            <div class=""form-group"">
                <label asp-for=""Imagem"" class=""control-label""></label>
                <input asp-for=""Imagem"" class=""form-control"" />
                <span asp-validation-for=""Imagem"" class=""text-danger""></span>
            </div>

            <div class=""form-group"">
                <label asp-for=""Altura"" class=""control-label""></label>
                <input asp-for=""Altura"" class=""form-control"" />
                <span asp-validation-for=""Altura"" class=""text-danger""></span>
            </div>

            <div class=""form-group"">
                <label asp-for=""Largura"" class=""control-label""></label>
                <input asp-for=""Largura""");
            WriteLiteral(@" class=""form-control"" />
                <span asp-validation-for=""Largura"" class=""text-danger""></span>
            </div>

            <div class=""form-group"">
                <label asp-for=""Profundidade"" class=""control-label""></label>
                <input asp-for=""Profundidade"" class=""form-control"" />
                <span asp-validation-for=""Profundidade"" class=""text-danger""></span>
            </div>

            <div class=""form-group"">
                <input type=""submit"" value=""Atualizar"" class=""btn btn-primary"" />
                <a class=""btn btn-info"" asp-action=""Index"">Voltar</a>
            </div>
        </form>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
