﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SweetSavory.Models;
using Microsoft.AspNetCore.Identity;

namespace SweetSavory
{
public class Startup
{
    public Startup(IHostingEnvironment env)
    {
    var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddJsonFile("appsettings.json");
    Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
    services.AddMvc();

    services.AddEntityFrameworkMySql()
        .AddDbContext<SweetSavoryContext>(options => options
        .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));

        services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<SweetSavoryContext>()
                .AddDefaultTokenProviders();
    }

    public void Configure(IApplicationBuilder app)
    {
    app.UseStaticFiles();

    app.UseDeveloperExceptionPage();

    app.UseAuthentication();

    app.UseMvc(routes =>
    {
    routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
    });

    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Critical Error Captain!");
    });

    }
}
    
}
