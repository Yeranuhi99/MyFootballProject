using Microsoft.EntityFrameworkCore;
using MyFootballProject.Data;
using MyFootballProject.Data.Repositories;
using MyFootballProject.Data.Repositories.Interfaces;
using MyFootballProject.Services;
using MyFootballProject.Services.Interfaces;

namespace MyFootballProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args); 

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<FootballDataContext>
               (opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MyFootballDB")));
            builder.Services.AddScoped<IClubRepository, ClubRepository>();
            builder.Services.AddScoped<ICoachRepository, CoachRepository>();
            builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
            builder.Services.AddScoped<IPresidentRepository, PresidentRepository>();
            builder.Services.AddScoped<IStadiumRepository, StadiumRepository>();
            builder.Services.AddScoped<IClubService, ClubService>();
            builder.Services.AddScoped<ICoachService, CoachService>();
            builder.Services.AddScoped<IPlayerService, PlayerService>();
            builder.Services.AddScoped<IPresidentService, PresidentService>();
            builder.Services.AddScoped<IStadiumService, StadiumService>();
            var app = builder.Build();

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