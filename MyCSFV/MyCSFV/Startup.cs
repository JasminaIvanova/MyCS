﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyCSFV.Data;
using MyCSFV.Areas.Identity.Data;
using MyCSFV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSFV
{
    public class Startup
    {
       
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private MyCSFVUser adminUser;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          /*services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()*/;
            services.AddControllersWithViews();
            services.AddRazorPages();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            CreateUserAndRoles(services).GetAwaiter().GetResult();
        }

        public async Task CreateUserAndRoles(IServiceProvider serviceProvider)
        {

            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<MyCSFVUser>>();

            var roleExist = await RoleManager.RoleExistsAsync("SuperAdmin");
            if (!roleExist)
            {
                IdentityResult role = await RoleManager.CreateAsync(new IdentityRole("SuperAdmin"));

                adminUser = new MyCSFVUser();
                adminUser.UserName = "hello@gmail.com";
                adminUser.Email = "hello@gmail.com";
                adminUser.EmailConfirmed = true;

                string pass = "1234567Аa@";
                var admin = await UserManager.CreateAsync(adminUser, pass);
                if (admin.Succeeded)
                {
                    await UserManager.AddToRoleAsync(adminUser, "SuperAdmin");
                }
            }
        }

    }
}
    

