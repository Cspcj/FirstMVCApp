using FirstMVCApp.Controllers;
using FirstMVCApp.DataContext;
using FirstMVCApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Auth0.AspNetCore.Authentication;

namespace FirstMVCApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ProgrammingClubDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
            
            builder.Services.AddTransient<ProgrammingClubDataContext, ProgrammingClubDataContext>();
            builder.Services.AddTransient<AnnouncementsRepository, AnnouncementsRepository>();
            builder.Services.AddTransient<CodeSnippetsRepository, CodeSnippetsRepository>();
            builder.Services.AddTransient<MembershipsRepository, MembershipsRepository>();
            builder.Services.AddTransient<MembershipTypesRepository, MembershipTypesRepository>();
            builder.Services.AddTransient<MembersRepository, MembersRepository>();
            //builder.Services.AddScoped<ProgrammingClubDataContext>();     // creaza un obiect pe durata unei sesiuni
            //builder.Services.AddSingleton<ProgrammingClubDataContext>();  // asigura o singura instanta a unui obiect pe perioada unei cereri

            builder.Services.AddAuth0WebAppAuthentication(options =>
                {
                    options.Domain = builder.Configuration["Auth0:Domain"];
                    options.ClientId = builder.Configuration["Auth0:ClientId"];
                });

            var app = builder.Build();
            app.UseAuthentication();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}