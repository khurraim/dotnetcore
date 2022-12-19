using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FoodOrderApp.Models;

namespace FoodOrderApp.Data
{
    public class ApplicationDbContext : DbContext
    {
      
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<FoodOrderApp.Models.Products> Products { get; set; }

        public DbSet<FoodOrderApp.Models.Message> Message { get; set; }

        public DbSet<FoodOrderApp.Models.Order> Order { get; set; }

    }
}
