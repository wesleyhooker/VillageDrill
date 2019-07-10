using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VillageDrill.Models;

namespace VillageDrill.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        //DB Tables
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<AssemblyHistory > AssemblyHistory { get; set; }
        public DbSet<AssemblyRecipe> AssemblyRecipe { get; set; }
        public DbSet<InventoryLog> InventoryLog { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Measures> Measures { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<RecievedItems> RecievedItems { get; set; }
        public DbSet<RecipeLine> RecipeLine { get; set; }
    }
}
