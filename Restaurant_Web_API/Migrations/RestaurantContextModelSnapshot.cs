﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant_Web_API.Database_Class;

#nullable disable

namespace Restaurant_Web_API.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Restaurant_Web_API.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"));

                    b.Property<string>("business_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("business_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("business_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("business_postal_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("business_state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("inspection_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("inspection_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("inspection_score")
                        .HasColumnType("int");

                    b.Property<string>("inspection_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("risk_category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("violation_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("violation_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("RestaurantSet");
                });
#pragma warning restore 612, 618
        }
    }
}