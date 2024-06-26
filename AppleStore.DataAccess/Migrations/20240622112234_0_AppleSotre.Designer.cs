﻿// <auto-generated />
using System;
using AppleStore.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppleStore.DataAccess.Migrations
{
    [DbContext(typeof(AppleStoreDbContext))]
    [Migration("20240622112234_0_AppleSotre")]
    partial class _0_AppleSotre
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("AppleStore.DataAccess.Entities.CartItemEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CartItems", (string)null);
                });

            modelBuilder.Entity("AppleStore.DataAccess.Entities.CartItemProductEntity", b =>
                {
                    b.Property<Guid>("CartItemId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("TEXT");

                    b.HasKey("CartItemId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItemProduct", (string)null);
                });

            modelBuilder.Entity("AppleStore.DataAccess.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("AppleStore.DataAccess.Entities.CartItemProductEntity", b =>
                {
                    b.HasOne("AppleStore.DataAccess.Entities.CartItemEntity", "CartItem")
                        .WithMany("CartItemProducts")
                        .HasForeignKey("CartItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppleStore.DataAccess.Entities.ProductEntity", "Product")
                        .WithMany("CartItemProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CartItem");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AppleStore.DataAccess.Entities.CartItemEntity", b =>
                {
                    b.Navigation("CartItemProducts");
                });

            modelBuilder.Entity("AppleStore.DataAccess.Entities.ProductEntity", b =>
                {
                    b.Navigation("CartItemProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
