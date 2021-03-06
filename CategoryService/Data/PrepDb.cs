using System;
using System.Linq;
using CategoryService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CategoryService.Data
{
    public static class PrepDb
    {
        public static void PrepSeed(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                Seed(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void Seed(AppDbContext context)
        {
            if(!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category(){Name = "Food", CreateDate = DateTime.Now},
                    new Category(){Name = "Eletronics", CreateDate = DateTime.Now},
                    new Category(){Name = "Health", CreateDate = DateTime.Now}
                );
            }

            context.SaveChanges();
        }
    }
}