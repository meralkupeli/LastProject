using Microsoft.EntityFrameworkCore;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.DAL.DbContextManagement
{
    public class DatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options){ }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
