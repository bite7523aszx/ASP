using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class GameVIewContext : DbContext
    {
        public GameVIewContext (DbContextOptions<GameVIewContext> options)
            : base(options)
        {
        }


        public DbSet<Customer_Profile> Customer_Profile { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Orderde> Orderde { get; set; }
        public DbSet<Game_mall> Game_mall { get; set; }
        public DbSet<Purchase_quantitycs> Purchase_quantitycs { get; set; }
        public DbSet<Game_mallComment> Game_mallComment { get; set; }
        public DbSet<shopping> shopping { get; set; }
        public DbSet<Salecs> Salecs{ get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Purchase_quantitycs>(builder =>
        //    {
        //        builder.HasKey(p => new { p.Order_number, p.Game_number });
        //        builder.HasOne(p => p.Order)
        //               .WithMany(p => p.Purchase_quantitycss)
        //               .HasForeignKey(p => p.Order_number);
        //        builder.HasOne(p => p.Game_mall)
        //               .WithMany(p => p.Purchase_quantitycss)
        //               .HasForeignKey(p => p.Game_number);
        //    });
        //}
    }
}
