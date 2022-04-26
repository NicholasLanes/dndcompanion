using dnd.Models;
using dnd.Models.Auth;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnd
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
            //Memorycache and addsession must be called before addcontrollerswithvies
            services.AddMemoryCache();

            //Adding session state and changing the default session state settings
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(60 * 10);//change timeout to 10 min default is 20 min
                options.Cookie.HttpOnly = false;//default is true
                options.Cookie.IsEssential = true;//default is false
            });
            services.AddControllersWithViews().AddNewtonsoftJson();
            services.AddDbContext<CharacterContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CharacterContext")));

            // Configuring Identity options
            services.AddIdentity<User, IdentityRole>(options =>
            {
                // Password Configuration
                options.Password.RequireUppercase = false; // Password does not require an uppercase character
                options.Password.RequireLowercase = true; // Password requires a lowercase character
                options.Password.RequireNonAlphanumeric = false; // Password does not require a non-alphanumeric character
                options.Password.RequiredLength = 4; // Password required to be at least 5 characters in length

            }).AddEntityFrameworkStores<CharacterContext>().AddDefaultTokenProviders();
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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // Enable Authentication
            app.UseAuthorization(); // Enable Authorization

            app.UseSession(); // Enable Session

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
