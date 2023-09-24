using DailyFood.Server.Data;
using DailyFood.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;

namespace DailyFood
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //builder.Services.AddIdentityServer().AddApiAuthorization<ApplicationUser, ApplicationDbContext>();
            //Inserted instead of above, based on: https://learn.microsoft.com/en-us/aspnet/core/blazor/security/webassembly/hosted-with-identity-server?view=aspnetcore-7.0&tabs=visual-studio#api-authorization-options
            builder.Services.AddIdentityServer()
            .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options => {
                options.IdentityResources["openid"].UserClaims.Add("name");
                options.ApiResources.Single().UserClaims.Add("name");
                options.IdentityResources["openid"].UserClaims.Add("role");
                options.ApiResources.Single().UserClaims.Add("role");
            });

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Remove("role");

            builder.Services.AddAuthentication()
                .AddIdentityServerJwt();

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthorization();


            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}