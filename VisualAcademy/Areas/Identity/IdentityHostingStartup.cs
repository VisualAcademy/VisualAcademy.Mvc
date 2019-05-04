using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VisualAcademy.Data;

[assembly: HostingStartup(typeof(VisualAcademy.Areas.Identity.IdentityHostingStartup))]
namespace VisualAcademy.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

                //// Startup.cs를 사용하지 않고 IdentityHostingStartup.cs 파일에서 IdentityUser와 ApplicatoinDbContext를 지정하는 경우
                //services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<ApplicationDbContext>();

            });
        }
    }
}
