#pragma checksum "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3becbd92ab06e6f2a8876473941d1f51785ebcc8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DotnetApi.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/_Imports.razor"
using DotnetApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/_Imports.razor"
using DotnetApi.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/Luke/Desktop/Term4/4870FullStackWeb/assignment2/DotnetApi/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591