#pragma checksum "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\AddArticle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e1098d2fac95b8f3fcc68cb4870da5e3884a5e"
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
#line 2 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\AddArticle.razor"
using Article.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddArticle")]
    public partial class AddArticle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add Article</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Nom\" class=\"control-label\">Nom</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "Nom");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\AddArticle.razor"
                                                               obj.Nom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Nom = __value, obj.Nom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Description\" class=\"control-label\">Description</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "Description");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\AddArticle.razor"
                                                                       obj.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Description = __value, obj.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"Prix\" class=\"control-label\">Prix</label>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "form", "Prix");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\AddArticle.razor"
                                                                obj.Prix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Prix = __value, obj.Prix));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "<label for=\"Disponible\" class=\"control-label\">Disponible</label>\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "form", "Disponible");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\AddArticle.razor"
                                                                      obj.Disponible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Disponible = __value, obj.Disponible));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-md-4");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\AddArticle.razor"
                                                                        CreateArticle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\AddArticle.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\Cours\Web\5emeAnnee\C#\Article\Article\Pages\AddArticle.razor"
       
    Article obj = new Article();
    protected async void CreateArticle()
    {
        await articleService.InsertArticleAsync(obj);
        NavigationManager.NavigateTo("Articles");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Articles");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArticleService articleService { get; set; }
    }
}
#pragma warning restore 1591
