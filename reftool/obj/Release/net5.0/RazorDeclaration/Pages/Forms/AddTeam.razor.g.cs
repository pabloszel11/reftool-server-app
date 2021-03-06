// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace reftool_blazor_server.Pages.Forms
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
#line 3 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Forms\AddTeam.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Forms\AddTeam.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Forms\AddTeam.razor"
using reftool_blazor_server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Forms/AddTeam")]
    public partial class AddTeam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Forms\AddTeam.razor"
 
    private List<TeamModel> teams;
    private List<TeamModel> specificTeam;

    private TeamFormModel newForm = new TeamFormModel();

    protected override async Task OnInitializedAsync()
    {
        teams = await teamdb.GetTeams();
        //specificTeam = await teamdb.GetTeamID("Chicago Bulls");

        //  Console.WriteLine(specificTeam[0].ID);
    }

    public async Task Insert()
    {
        TeamModel team = new TeamModel
        {
            TeamName = newForm.TeamName
        };
        await teamdb.InsertTeam(team);

        specificTeam = await teamdb.GetTeamID(newForm.TeamName);
        Console.WriteLine(specificTeam[0].TeamName);
        int id = specificTeam[0].ID;
        Console.WriteLine(id);

        foreach (var player in newForm.Players)
        {
            player.TeamID = id;
            if (player.FirstName != null && player.LastName != null)
                await playerdb.InsertPlayer(player);
        }

        newForm = new TeamFormModel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlayerData playerdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeamData teamdb { get; set; }
    }
}
#pragma warning restore 1591
