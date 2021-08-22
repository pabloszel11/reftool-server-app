#pragma checksum "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca237633787533a668392d1713e1d94ab841fcb9"
// <auto-generated/>
#pragma warning disable 1591
namespace reftool_blazor_server.Pages.Forms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using reftool_blazor_server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using reftool_blazor_server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\C5315422\source\repos\thesis\reftool\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
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
            __builder.AddMarkupContent(0, "<h2>Add Team</h2>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Please provide a team name and a minimum of 5 players</h4>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
                  newForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
                                           Insert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "table");
                __builder2.AddAttribute(11, "class", "table table-striped");
                __builder2.OpenElement(12, "tr");
                __builder2.AddAttribute(13, "style", "display:inline");
                __builder2.OpenElement(14, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "teamName");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
                                                      newForm.TeamName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newForm.TeamName = __value, newForm.TeamName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newForm.TeamName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 25 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
         foreach (var player in newForm.Players)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(20, "tr");
                __builder2.AddAttribute(21, "style", "display:inline");
                __builder2.OpenElement(22, "td");
                __builder2.AddAttribute(23, "style", "width: 10%");
                __Blazor.reftool_blazor_server.Pages.Forms.AddTeam.TypeInference.CreateInputNumber_0(__builder2, 24, 25, "playerNo", 26, 
#nullable restore
#line 28 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
                                                                               player.Number

#line default
#line hidden
#nullable disable
                , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => player.Number = __value, player.Number)), 28, () => player.Number);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenElement(30, "td");
                __builder2.AddAttribute(31, "style", "width: 10%");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "id", "playerFirstName");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
                                                                                    player.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => player.FirstName = __value, player.FirstName))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => player.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "td");
                __builder2.AddAttribute(39, "style", "width: 10%");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "id", "playerLastName");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
                                                                                   player.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => player.LastName = __value, player.LastName))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => player.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 32 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, " \r\n    <br>\r\n    \r\n\r\n    ");
                __builder2.AddMarkupContent(46, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 42 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
 if (teams is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "<p><em>Loading</em></p>");
#nullable restore
#line 45 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazorise.Table>(48);
            __builder.AddAttribute(49, "class", "table");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "<thead><tr><th>Team Name</th></tr></thead>\r\n        ");
                __builder2.OpenElement(52, "tbody");
#nullable restore
#line 55 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
             foreach (var team in teams)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(53, "tr");
                __builder2.OpenElement(54, "td");
                __builder2.AddContent(55, 
#nullable restore
#line 58 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
                         team.TeamName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 60 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 63 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\C5315422\source\repos\thesis\reftool\Pages\Forms\AddTeam.razor"
 
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
namespace __Blazor.reftool_blazor_server.Pages.Forms.AddTeam
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
