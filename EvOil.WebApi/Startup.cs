using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvOil.Business.Services.Abstractions;
using EvOil.Business.Services.Implementations;
using EvOil.Business;
using EvOil.Persistence;
using EvOil.WebApi.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace EvOil.WebApi
{
    internal sealed partial class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddScoped<IUsersService, UserService>();
            _ = services.AddScoped<IOilService, OilService>();

            _ = services.AddControllers();

            _ = services.AddDbContext<IEvOilDatabaseContext, EvOilDatabaseContext>(dbContextOptionsBuilder =>
             {
                 _ = dbContextOptionsBuilder.UseSqlServer(_configuration.GetConnectionString("LocalDatabase"));
             });
        }
        public static void Configure(IApplicationBuilder app)

        {
            _ = app.UseRouting();
            _ = app.UseMiddleware<ExceptionMiddleware>();

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = Path.Join(env.ContentRootPath, "../client");
            });

            _ = app.UseEndpoints(endpoints =>
              {
                  _ = endpoints.MapControllers();
              });
        }
    }
}