using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
        {

        }
        public DbSet<Customer_Profile> Customer_Profile { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Game_mall> Game_mall { get; set; }
        public DbSet<Purchase_quantitycs> Purchase_quantitycs { get; set; }
        public DbSet<Game_mallComment> Game_mallComments { get; set; }
        public DbSet<Orderde> Orderde { get; set; }
        public DbSet<shopping> shopping { get; set; }
        public DbSet<Game_order> Game_order { get; set; }

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

