using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DAL.DbContextManagement
{
    public static class SeedData
    {
        public static void Initialize(DatabaseContext context)
        {
            if(context.Products.Any())
            {
                return;
            }
            context.Products.AddRange(
                new Product { Name = "TV", Price = 9.99M, Description = "mük oldu aşko" },
                new Product { Name = "Playstation", Price = 19.99M, Description = "mük oldu aşko" },
                new Product { Name = "Bilgisayar", Price = 29.99M, Description = "mük oldu aşko" }
            );

            context.SaveChanges();
        }
    }
}
