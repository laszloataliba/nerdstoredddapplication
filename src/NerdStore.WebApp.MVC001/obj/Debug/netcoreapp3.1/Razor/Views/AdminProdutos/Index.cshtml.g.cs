#pragma checksum "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c7b8a6499f488b89b1aae89c2e9b7d1c8409c47f14972bba7bbea47f05fdc35a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_AdminProdutos_Index), @"mvc.1.0.view", @"/Views/AdminProdutos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c7b8a6499f488b89b1aae89c2e9b7d1c8409c47f14972bba7bbea47f05fdc35a", @"/Views/AdminProdutos/Index.cshtml")]
    #nullable restore
    internal sealed class Views_AdminProdutos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
       IEnumerable<NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
  
    ViewData["Title"] = "Vitrine";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<style>
    h4 {
        font-weight: 600;
    }

    p {
        font-size: 12px;
        margin-top: 5px;
    }

    .price {
        font-size: 30px;
        margin: 0 auto;
        color: #333;
    }

    .right {
        float: right;
        border-bottom: 2px solid #4B8E4B;
    }

    .thumbnail {
        opacity: 0.70;
        -webkit-transition: all 0.5s;
        transition: all 0.5s;
    }

        .thumbnail:hover {
            opacity: 1.00;
            box-shadow: 0px 0px 10px #4bc6ff;
        }

    .line {
        margin-bottom: 5px;
    }

    ");
            WriteLiteral(@"@media screen and (max-width: 770px) {
        .right {
            float: left;
            width: 100%;
        }
    }

    .product_view .modal-dialog {
        max-width: 800px;
        width: 100%;
    }

    .pre-cost {
        text-decoration: line-through;
        color: #a5a5a5;
    }

    .space-ten {
        padding: 10px 0;
    }
</style>
<div class=""container"">

    <h1>Administração de Produtos</h1>
    <hr />
    <div class=""row"">
        <a asp-controller=""AdminProdutos"" asp-action=""NovoProduto"" class=""btn btn-success right"">+ Adicionar Novo</a>
    </div>
    <hr />
    <div class=""row"">
        <!-- BEGIN PRODUCTS -->
");
#nullable restore
#line 73 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
          
            foreach (var produto in Model.OrderBy(p => p.CategoriaId))
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"col-md-3 col-sm-6\">\r\n                    <span class=\"thumbnail\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7b8a6499f488b89b1aae89c2e9b7d1c8409c47f14972bba7bbea47f05fdc35a5935", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1657, "~/Images/", 1657, 9, true);
            AddHtmlAttributeValue("", 1666, 
#nullable restore
#line 78 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
                                                                     produto.Imagem

#line default
#line hidden
#nullable disable
            , 1666, 15, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h4>");
            Write(
#nullable restore
#line 79 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
                             produto.Nome

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n                        <p>");
            Write(
#nullable restore
#line 80 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
                            produto.QuantidadeEstoque

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" em estoque</p>\r\n                        <p>");
            Write(
#nullable restore
#line 81 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
                            produto.Descricao

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                        <p class=\"price\">");
            Write(
#nullable restore
#line 82 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
                                          produto.Valor.ToString("C")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                        <hr class=\"line\">\r\n                        <div class=\"row\">\r\n                            <a asp-controller=\"AdminProdutos\" asp-action=\"AtualizarProduto\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2108, "\"", 2134, 1);
            WriteAttributeValue("", 2123, 
#nullable restore
#line 85 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
                                                                                                           produto.Id

#line default
#line hidden
#nullable disable
            , 2123, 11, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success right\">Editar</a> &nbsp;\r\n                            <a asp-controller=\"AdminProdutos\" asp-action=\"AtualizarEstoque\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2276, "\"", 2302, 1);
            WriteAttributeValue("", 2291, 
#nullable restore
#line 86 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
                                                                                                           produto.Id

#line default
#line hidden
#nullable disable
            , 2291, 11, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info right\">Estoque</a>\r\n                        </div>\r\n                    </span>\r\n                </div>\r\n");
#nullable restore
#line 90 "C:\Users\lataliba\OneDrive - Cinemark Holdings, Inc\Desktop\NerdStore\src\NerdStore.WebApp.MVC001\Views\AdminProdutos\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n        <!-- END PRODUCTS -->\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
