using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK_06_12_21.Models;

namespace TASK_06_12_21.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
        public DbSet<Users> Users { get; set;}
        public DbSet<Baskets> Baskets { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Favorites> Favorites{ get; set; }



    }
}
