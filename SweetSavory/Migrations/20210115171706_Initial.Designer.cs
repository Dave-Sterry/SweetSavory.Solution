﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SweetSavory.Models;

namespace SweetSavory.Migrations
{
    [DbContext(typeof(SweetSavoryContext))]
    [Migration("20210115171706_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SweetSavory.Models.Flavor", b =>
                {
                    b.Property<int>("FlavorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FlavorName");

                    b.HasKey("FlavorId");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("SweetSavory.Models.FlavorTreat", b =>
                {
                    b.Property<int>("FlavorTreatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FlavorId");

                    b.Property<int>("TreatId");

                    b.HasKey("FlavorTreatId");

                    b.HasIndex("FlavorId");

                    b.HasIndex("TreatId");

                    b.ToTable("FlavorTreat");
                });

            modelBuilder.Entity("SweetSavory.Models.Treat", b =>
                {
                    b.Property<int>("TreatId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TreatName");

                    b.HasKey("TreatId");

                    b.ToTable("Treats");
                });

            modelBuilder.Entity("SweetSavory.Models.FlavorTreat", b =>
                {
                    b.HasOne("SweetSavory.Models.Flavor", "Flavor")
                        .WithMany("JoinEntries")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SweetSavory.Models.Treat", "Treat")
                        .WithMany("JoinEntries")
                        .HasForeignKey("TreatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
