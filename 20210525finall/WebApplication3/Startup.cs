using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using WebApplication3.Access;
using WebApplication3.Asscss;
using WebApplication3.Data;
using WebApplication3.Models.Data;

namespace WebApplication3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(7);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;

            });
            services.AddTransient<IGame_Story, Game_Story>();
            services.AddTransient<sqlDataAcess>();
            services.AddTransient<ISale, Sale>();


            //services.AddDbContext<WebApplication3Context>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("WebApplication3Context")));
            string path = Directory.GetCurrentDirectory();
            services.AddDbContext<GameVIewContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("GameVIewContext").Replace("[DataDirectory]", path)));

            services.AddDbContext<GameDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("GameVIewContext").Replace("[DataDirectory]", path)));

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Game_mallView}/{action=index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
