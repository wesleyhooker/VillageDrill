﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VillageDrill.Data;

namespace VillageDrill.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190723003735_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            /*modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });
*/
            modelBuilder.Entity("VillageDrill.Models.AssemblyHistory", b =>
                {
                    b.Property<int>("AssemblyHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssemblyDate");

                    b.Property<int>("ItemID");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<string>("Notes");

                    b.Property<int>("QtyAssembled");

                    b.HasKey("AssemblyHistoryID");

                    b.HasIndex("ItemID");

                    b.ToTable("AssemblyHistory");
                });

            modelBuilder.Entity("VillageDrill.Models.AssemblyRecipe", b =>
                {
                    b.Property<int>("AssemblyRecipeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID");

                    b.HasKey("AssemblyRecipeID");

                    b.HasIndex("ItemID");

                    b.ToTable("AssemblyRecipe");
                });

            modelBuilder.Entity("VillageDrill.Models.InventoryLog", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<int>("NewQty");

                    b.Property<int>("PreviousQty");

                    b.Property<bool>("Reconciled");

                    b.HasKey("LogID");

                    b.HasIndex("ItemID");

                    b.ToTable("InventoryLog");
                });
            /*
            modelBuilder.Entity("VillageDrill.Models.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("ItemName")
                        .IsRequired();

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<decimal>("ListRetailCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MaxQty");

                    b.Property<decimal>("MeasureAmnt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MeasureID");

                    b.Property<int>("OnHandQty");

                    b.Property<int>("ReorderQty");

                    b.HasKey("ItemID");

                    b.HasIndex("MeasureID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("VillageDrill.Models.Measures", b =>
                {
                    b.Property<int>("MeasureID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MeasureName")
                        .IsRequired();

                    b.HasKey("MeasureID");

                    b.ToTable("Measures");
                });
                */
            modelBuilder.Entity("VillageDrill.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateDelivered");

                    b.Property<int>("ItemID");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PurchaseOrderID");

                    b.Property<int>("QuantityOrdered");

                    b.Property<string>("VendorSKU")
                        .IsRequired();

                    b.HasKey("OrderItemID");

                    b.HasIndex("ItemID");

                    b.HasIndex("PurchaseOrderID");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("VillageDrill.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("PurchaseOrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOrdered");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<int>("VendorID");

                    b.Property<string>("VendorPO")
                        .IsRequired();

                    b.HasKey("PurchaseOrderID");

                    b.HasIndex("VendorID");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("VillageDrill.Models.RecievedItems", b =>
                {
                    b.Property<int>("RecievedID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<string>("Notes");

                    b.Property<int>("QuantityReceived");

                    b.Property<int>("VendorID");

                    b.HasKey("RecievedID");

                    b.HasIndex("VendorID");

                    b.ToTable("RecievedItems");
                });

            modelBuilder.Entity("VillageDrill.Models.RecipeLine", b =>
                {
                    b.Property<int>("RecipeLineID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssemblyRecipeID");

                    b.Property<int>("ItemID");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<int>("RequiredItemQuantity");

                    b.HasKey("RecipeLineID");

                    b.HasIndex("AssemblyRecipeID");

                    b.HasIndex("ItemID");

                    b.ToTable("RecipeLine");
                });

            modelBuilder.Entity("VillageDrill.Models.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<string>("VendorAddress")
                        .IsRequired();

                    b.Property<string>("VendorName")
                        .IsRequired();

                    b.HasKey("VendorID");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("VillageDrill.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VillageDrill.Models.AssemblyHistory", b =>
                {
                    b.HasOne("VillageDrill.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("VillageDrill.Models.AssemblyRecipe", b =>
                {
                    b.HasOne("VillageDrill.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("VillageDrill.Models.InventoryLog", b =>
                {
                    b.HasOne("VillageDrill.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("VillageDrill.Models.Item", b =>
                {
                    b.HasOne("VillageDrill.Models.Measures", "Measures")
                        .WithMany()
                        .HasForeignKey("MeasureID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("VillageDrill.Models.OrderItem", b =>
                {
                    b.HasOne("VillageDrill.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("VillageDrill.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("VillageDrill.Models.PurchaseOrder", b =>
                {
                    b.HasOne("VillageDrill.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("VillageDrill.Models.RecievedItems", b =>
                {
                    b.HasOne("VillageDrill.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("VillageDrill.Models.RecipeLine", b =>
                {
                    b.HasOne("VillageDrill.Models.AssemblyRecipe", "AssemblyRecipe")
                        .WithMany()
                        .HasForeignKey("AssemblyRecipeID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("VillageDrill.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
