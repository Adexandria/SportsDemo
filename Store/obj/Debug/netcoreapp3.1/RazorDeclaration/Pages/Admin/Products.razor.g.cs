#pragma checksum "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccd587eb6e29883efcb1ca85be2559d71ec5aa98"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Products : OwningComponentBase<IData>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\Products.razor"
       

    public IData Repository => Service;

    public IEnumerable<Details> ProductData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        ProductData = await Repository.GetDetails.ToListAsync();
    }

    public async Task DeleteProduct(Details p)
    {
        Repository.DeleteProduct(p);
        await UpdateData();
    }

    public string GetDetailsUrl(long id) => $"/admin/products/detail/{id}";
    public string GetEditUrl(long id) => $"/admin/products/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
