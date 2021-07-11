using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class WebApplication3Context : DbContext
    {
        public WebApplication3Context (DbContextOptions<WebApplication3Context> options)
            : base(options)
        {
        }

        public DbSet<Customer_Profile> Customer_Profile { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Game_mall> Game_mall { get; set; }
        public DbSet<Purchase_quantitycs> Purchase_quantitycs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Purchase_quantitycs>(builder =>
            {
                builder.HasKey(p => new { p.Order_number, p.Game_number });
                builder.HasOne(p => p.Order)
                       .WithMany(p => p.Purchase_quantitycss)
                       .HasForeignKey(p => p.Order_number);
                builder.HasOne(p => p.Game_mall)
                       .WithMany(p => p.Purchase_quantitycss)
                       .HasForeignKey(p => p.Game_number);
            });
        }
    }
}
