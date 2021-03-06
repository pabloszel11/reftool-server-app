#pragma checksum "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "671f6016bf93a0181b2396a7a9790129e167ebcd"
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
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "href", "/Teams/Edit/" + (
#nullable restore
#line 11 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                                 team.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Edit");
            __builder.CloseElement();
            __builder.OpenComponent<Blazorise.Icon>(5);
            __builder.AddAttribute(6, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                                                              IconName.Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                                                                                           () => deleteTeam(@team)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n        <br>");
#nullable restore
#line 13 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
         foreach (var player in team.TeamPlayers)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "h6");
            __builder.AddMarkupContent(10, "\r\n                #");
            __builder.AddContent(11, 
#nullable restore
#line 16 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                  player.Number

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.AddContent(13, 
#nullable restore
#line 16 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                 player.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 16 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                                   player.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/Players/Edit/" + (
#nullable restore
#line 16 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                                                                           player.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Edit");
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                 if (team.TeamPlayers.Count > 5)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazorise.Icon>(20);
            __builder.AddAttribute(21, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                IconName.Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                                             () => deletePlayer(@player)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 20 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            <br>");
#nullable restore
#line 23 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
         

        if(team.TeamPlayers.Count < 12)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "h6");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "/Players/Add/" + (
#nullable restore
#line 27 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
                                   Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Add a new player");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "<br>");
#nullable restore
#line 28 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<a href=\"/Teams\">Go Back</a>");
#nullable restore
#line 30 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<h4>There is no team with the given id!</h4>");
#nullable restore
#line 34 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\C5315422\Downloads\thesis\reftool\Pages\Teams\DisplayTeam.razor"
               
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
            async Task deletePlayer(PlayerModel player)
            {
                await playerdb.DeletePlayer(player);
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
