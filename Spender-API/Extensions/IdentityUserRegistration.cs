using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Spendr.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Persistence
{
   /// <summary>
   /// Registers Identity and Db context as a service
   /// </summary>
   public static class IdentityUserRegistration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void AddIdentityConfiguring(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<SpendrDbContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.User.RequireUniqueEmail = true;
            });
        }
    }
}
