#pragma checksum "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02b90ae8cab5cb523d2d2c41ff3216d211094dfc"
// <auto-generated/>
#pragma warning disable 1591
namespace Article.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using Article;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Cours\Web\5emeAnnee\C#\Article\Article\_Imports.razor"
using Article.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
using Article.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Articles")]
    public partial class Articles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "AddArticle");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<span class=\"oi oi-plus\" aria-hidden=\"true\">Add New</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Article Info</h1>");
#nullable restore
#line 11 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
 if (EmpObj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading... !</em></p>");
#nullable restore
#line 14 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Id</th>\r\n                <th>Nom</th>\r\n                <th>Description</th>\r\n                <th>Prix</th>\r\n                <th>Disponible</th>\r\n                <th>Action</th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 29 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
             foreach (var emp in EmpObj)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
#nullable restore
#line 32 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
__builder.AddContent(14, emp.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 33 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
__builder.AddContent(17, emp.Nom);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 34 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
__builder.AddContent(20, emp.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 35 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
__builder.AddContent(23, emp.Prix);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 36 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
__builder.AddContent(26, emp.Disponible);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "EditArticle/" + (
#nullable restore
#line 38 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
                                                               emp.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<span class=\"oi oi-pencil\" aria-hidden=\"true\">Edit</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "nav-link");
            __builder.AddAttribute(36, "href", "Delete/" + (
#nullable restore
#line 41 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
                                                          emp.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<span class=\"oi oi-trash\" aria-hidden=\"true\">Delete</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\Articles.razor"
       
    List<Article> EmpObj;
    protected override async Task OnInitializedAsync()
    {
        EmpObj = await Task.Run(() => articleService.GetAllArticlesAsync());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArticleService articleService { get; set; }
    }
}
#pragma warning restore 1591
