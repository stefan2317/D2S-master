using System;
using india.Areas.Identity.Data;
using india.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

[assembly: HostingStartup(typeof(india.Areas.Identity.IdentityHostingStartup))]
namespace india.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<indiaDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("indiaDBContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => {

                    options.SignIn.RequireConfirmedEmail = false;
                    options.User.RequireUniqueEmail = false;
                    options.Password.RequireUppercase = false;
                })
                
                    .AddEntityFrameworkStores<indiaDBContext>();
            });
        }
    }
}