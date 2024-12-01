using Microsoft.EntityFrameworkCore;
using PawnShop.Entities;
using PawnShop.Enums;

namespace PawnShop.Context
{
    public class PawnShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=pawnshop.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Items)
                .WithOne(i => i.Customer)
                .HasForeignKey(i => i.CustomerID);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Loans)
                .WithOne(l => l.Customer)
                .HasForeignKey(l => l.CustomerID);

            modelBuilder.Entity<Item>()
                .HasOne(i => i.Loan)
                .WithOne(l => l.Item)
                .HasForeignKey<Loan>(l => l.ItemID);

            modelBuilder.Entity<Other>()
                .HasMany(o => o.Items)
                .WithOne(i => i.Other)
                .HasForeignKey(i => i.OtherID);

            modelBuilder.Entity<Jewelry>()
                .HasMany(j => j.Items)
                .WithOne(i => i.Jewelry)
                .HasForeignKey(i => i.JewelryID);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Jewelry> Jewelries { get; set; }
        public DbSet<Other> Others { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}