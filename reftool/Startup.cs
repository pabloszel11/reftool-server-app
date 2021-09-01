using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Append.Blazor.Notifications;
using BlazorDownloadFile;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using DataAccessLibrary;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using reftool_blazor_server.Data;

namespace reftool_blazor_server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services
              .AddBlazorise(options =>
              {
                  options.ChangeTextOnKeyPress = true; 
              })
              .AddBootstrapProviders()
              .AddFontAwesomeIcons();
            services.AddNotifications();
            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            services.AddTransient<IPlayerData, PlayerData>();
            services.AddTransient<ITeamData, TeamData>();
            services.AddBlazorDownloadFile(ServiceLifetime.Scoped);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
