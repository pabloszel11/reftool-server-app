// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace reftool_blazor_server.Pages.Teams
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using reftool_blazor_server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using reftool_blazor_server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\C5315422\Downloads\thesis\reftool\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\ListTeams.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\ListTeams.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\ListTeams.razor"
using reftool_blazor_server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Teams")]
    public partial class ListTeams : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\ListTeams.razor"
       

    List<TeamModel> teams;
    protected override async Task OnInitializedAsync()
    {
        teams = await teamdb.GetTeams();
    }

    async Task deleteTeam(TeamModel team)
    {
        await teamdb.DeleteTeam(team);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlayerData playerdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeamData teamdb { get; set; }
    }
}
#pragma warning restore 1591
