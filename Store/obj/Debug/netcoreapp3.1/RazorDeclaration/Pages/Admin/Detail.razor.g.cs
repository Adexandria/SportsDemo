#pragma checksum "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\Detail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e562d386fbd733c48b949f6dd043db805ad791c"
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
    public partial class Detail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\HP 650\Documents\DEmo\SportsDemo\Store\Pages\Admin\Detail.razor"
       

    [Inject]
    public IData Repository { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Details Product { get; set; }

    protected override void OnParametersSet()
    {
        Product = Repository.GetDetails.FirstOrDefault(p => p.ProductId == Id);
    }

    public string EditUrl => $"/admin/products/edit/{Product.ProductId}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
