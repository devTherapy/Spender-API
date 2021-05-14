using Microsoft.AspNetCore.Identity;
using Spendr.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spendr.Persistence.Preceeder
{
    public static class Preceeder
    {
        /// <summary>
        /// Seeds the database with placeholder json data
        /// </summary>
        /// <returns></returns>
        public static async Task Seed(SpendrDbContext ctx, RoleManager<IdentityRole>roleManager,  UserManager<User>userManager)
        {
            await ctx.Database.EnsureCreatedAsync();
            var roles = new List<String>() { "Admin", "User" };

            if (roleManager.Roles.Any())
            {

            }
        }
    }
}
