using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Spendr.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spendr.Persistence.Seeder
{
    public static class Seeder
    {
        /// <summary>
        /// Seeds the database with placeholder json data
        /// </summary>
        /// <returns></returns>
        public static async Task SeedDB(SpendrDbContext ctx, RoleManager<IdentityRole>roleManager,  UserManager<User>userManager)
        {
            await ctx.Database.EnsureCreatedAsync();
            var roles = new List<String>() { "Admin", "User" };

            if (!roleManager.Roles.Any())
            {
                for (int i = 0; i < roles.Count; i++)
                {
                    var role = new IdentityRole(roles[i]);
                    await roleManager.CreateAsync(role);
                }

            }
            var cardTransactionCategories = TransformJSONtoPOCO<CardTransactionCategory>("CardTransactionCategory.json");
            //seed the wallet and card transaction categories
            if (!ctx.CardTransactionCategories.Any())
            {
                foreach (var item in cardTransactionCategories)
                {
                   await ctx.CardTransactionCategories.AddAsync(item);
                   await ctx.SaveChangesAsync();
                }
            }
            var walletTransactionCategories = TransformJSONtoPOCO<WalletTransactionCategory>("WalletTransactionCategory.json");
            if (!ctx.WalletTransactionCategories.Any())
            {
                foreach (var item in walletTransactionCategories)
                {
                    await ctx.WalletTransactionCategories.AddAsync(item);
                    await ctx.SaveChangesAsync();
                }

            }
            //seed merchants
            var Merchants = TransformJSONtoPOCO<Merchant>("Merchants.json");
            //seed the wallet and card transaction categories
            if (!ctx.Merchants.Any())
            {
                foreach (var item in Merchants)
                {
                    await ctx.Merchants.AddAsync(item);
                    await ctx.SaveChangesAsync();
                }
            }
            //seed users
            var Users = TransformJSONtoPOCO<User>("Users.json");
            if (!ctx.Users.Any())
            {
                int counter = 0;
                foreach (var user in Users)
                {
                    var result = await userManager.CreateAsync(user, "P@ssword");
                    if (!result.Succeeded)
                    {
                       HandlePreSeederError(result);
                    }
                    _ = counter == 1 ? await userManager.AddToRoleAsync(user, roles[0]) : await userManager.AddToRoleAsync(user, roles[1]);
                    counter++;
                }
            }

        }

        /// <summary>
        /// Show errors if issues when adding user to database
        /// </summary>
        /// <param name="result"></param>
        /// <param name="userType"></param>
        private static void HandlePreSeederError(IdentityResult result)
        {
            var errMsg = "";
            foreach (var error in result.Errors)
            {
                errMsg += error.Description;
            }
            throw new Exception(errMsg);
        }

        private static List<Tmodel> TransformJSONtoPOCO<Tmodel>(string json)
        {
            var path = Path.GetFullPath(@"../Spendr.Persistence/Seeder/" + json);
            return JsonConvert.DeserializeObject<List<Tmodel>>(File.ReadAllText(path));
        }

    }
}
