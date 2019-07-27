using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VillageDrill.Models.Objects;

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
        public DbSet<ReceivedItems> ReceivedItems { get; set; }
        public DbSet<RecipeLine> RecipeLine { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
        }
    }
}
