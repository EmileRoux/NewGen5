﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewGen5Razor.Models;

namespace NewGen5Razor.Migrations
{
    [DbContext(typeof(NewGenContext))]
    [Migration("20180809144917_testmigrate")]
    partial class testmigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NewGen5Razor.Models.Vendors", b =>
                {
                    b.Property<int>("VendorsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountBranch");

                    b.Property<string>("AccountNumber");

                    b.Property<string>("Email");

                    b.Property<string>("PhysicalAddress");

                    b.Property<string>("PostalAddress");

                    b.Property<int>("PreferencedID");

                    b.Property<string>("Telephone");

                    b.Property<string>("VendorName");

                    b.Property<int>("VendorTypeID");

                    b.Property<string>("VendorVATNumber");

                    b.HasKey("VendorsID");

                    b.ToTable("Vendors");
                });
#pragma warning restore 612, 618
        }
    }
}