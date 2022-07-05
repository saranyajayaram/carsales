﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using carsales;

#nullable disable

namespace carsales.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220705143204_CdCarsData")]
    partial class CdCarsData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("carsales.Models.Cars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carmodel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gearbox")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<int>("Modelyear")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Brand = "Ford",
                            Carmodel = "Figo",
                            Gearbox = "Automatic",
                            Mileage = 3000,
                            Modelyear = 2010,
                            Price = 23000.0,
                            Seats = 5
                        },
                        new
                        {
                            Id = 3,
                            Brand = "BMW",
                            Carmodel = "X1",
                            Gearbox = "Automatic",
                            Mileage = 5000,
                            Modelyear = 2009,
                            Price = 40000.0,
                            Seats = 5
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Audi",
                            Carmodel = "A3",
                            Gearbox = "Automatic",
                            Mileage = 3000,
                            Modelyear = 2005,
                            Price = 23000.0,
                            Seats = 5
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Volvo",
                            Carmodel = "v40",
                            Gearbox = "Automatic",
                            Mileage = 3000,
                            Modelyear = 2012,
                            Price = 50000.0,
                            Seats = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}