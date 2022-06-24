using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bascue_WebAppFinalProj.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Bascue_WebAppFinalProj.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //ADD ONE PRODUCT
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Moon Knight #1",
                Description = "First appearance of Mon Knight in standalone comic",
                Inventory = 4,
                Price = 699.99M
            });
        }
        public DbSet<Bascue_WebAppFinalProj.Models.Product> Product { get; set; }
    }
}
