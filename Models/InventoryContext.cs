using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB2EntityFrameworkPractie.Models
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<SalesPerson> SalesPerson { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Tax> Tax { get; set; }

        public InventoryContext(DbContextOptions<InventoryContext> options): base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceDetail>()
                .HasKey(c => new { c.InvoiceID, c.ProductID });
            //modelBuilder.Entity<Client>()
            //            .HasOne(a => a.Entity)
            //            .WithOne(b => b.Client)
            //            .HasForeignKey<Entity>(b => b.EntityID);   
            //modelBuilder.Entity<SalesPerson>()
            //            .HasOne(a => a.Entity)
            //            .WithOne(b => b.SalesPerson)
            //            .HasForeignKey<Entity>(b => b.EntityID);
        }
    }
}
