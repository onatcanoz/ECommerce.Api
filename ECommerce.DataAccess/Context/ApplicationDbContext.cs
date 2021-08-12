using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.Context
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=ONIX-PC\SQLEXPRESS;database=ECommerceDb;user id=sa;password=sa;multipleactiveresultsets=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(product => product.Basket)
                .WithMany(basket => basket.Products)
                .HasForeignKey(product => product.BasketId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasOne(product => product.Order)
                .WithMany(order => order.Products)
                .HasForeignKey(product => product.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
}
