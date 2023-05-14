using AngularDemo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace AngularDemo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        => services.AddDbContext<AppDBContext>();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }
    }
}
