#pragma checksum "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6847e21313ac918305fbe03a4b040c31f8cf73a2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Store.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\_Imports.razor"
using Store.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/create")]
    public partial class Editor : OwningComponentBase<IData>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\Editor.razor"
       

    public IData Repository => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public long Id { get; set; } = 0;

    public Details Product { get; set; } = new Details();

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            Product = Repository.GetDetails.FirstOrDefault(p => p.ProductId == Id);
        }
    }

    public void SaveProduct()
    {
        if (Id == 0)
        {
            Repository.CreateProduct(Product);
        }
        else
        {
            Repository.SaveProduct(Product);
        }
        NavManager.NavigateTo("/admin/products");
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
