using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Spendr.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
            services.AddDbContext<SpendrDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("SpendrApp")));
        }
    }
}
