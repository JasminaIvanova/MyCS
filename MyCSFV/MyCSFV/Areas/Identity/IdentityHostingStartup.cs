using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCSFV.Data;
using MyCSFV.Areas.Identity.Data;
using MyCSFV.Data;

[assembly: HostingStartup(typeof(MyCSFV.Areas.Identity.IdentityHostingStartup))]
namespace MyCSFV.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {

            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<MyCSFVContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<MyCSFVUser>(options => options.SignIn.RequireConfirmedAccount = true)
                 .AddRoles<IdentityRole>()
                 .AddEntityFrameworkStores<MyCSFVContext>();



            });
        }


    }
}