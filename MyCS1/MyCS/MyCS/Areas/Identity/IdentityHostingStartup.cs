using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCS.Areas.Identity.Data;
using MyCS.Data;

[assembly: HostingStartup(typeof(MyCS.Areas.Identity.IdentityHostingStartup))]
namespace MyCS.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<logDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("logDBContextConnection")));

                services.AddDefaultIdentity<MyCSUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<logDBContext>();
            });
        }
    }
}