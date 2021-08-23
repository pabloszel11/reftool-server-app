#pragma checksum "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f28b40b4297b45a0d0380f5ed04be2dc549d910"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Teams/{id:int}")]
    public partial class DisplayTeam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
 if (team != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, 
#nullable restore
#line 11 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
         team.TeamName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "<br>");
#nullable restore
#line 12 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
     foreach (var player in team.TeamPlayers)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h6");
            __builder.AddContent(4, "#");
            __builder.AddContent(5, 
#nullable restore
#line 14 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
              player.Number

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 14 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                             player.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, " ");
            __builder.AddContent(9, 
#nullable restore
#line 14 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                               player.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        <br>");
#nullable restore
#line 16 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<a href=\"/Teams\">Go Back</a>");
#nullable restore
#line 18 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<h4>There is no team with the given id!</h4>");
#nullable restore
#line 22 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
       
    [Parameter]
    public int Id { get; set; }

    List<TeamModel> teamList;
    TeamModel team;
    List<PlayerModel> players;

    protected override async Task OnInitializedAsync()
    {
        teamList = await teamdb.GetTeam(Id.ToString());
        players = await playerdb.GetPlayersFromTeam(Id.ToString());
        team = new TeamModel();
        team.TeamName = teamList[0].TeamName;
        team.TeamPlayers = players;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlayerData playerdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeamData teamdb { get; set; }
    }
}
#pragma warning restore 1591
