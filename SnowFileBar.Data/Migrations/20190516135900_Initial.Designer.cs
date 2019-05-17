﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SnowFileBar.Data;

namespace SnowFileBar.Data.Migrations
{
    [DbContext(typeof(FileDataContext))]
    [Migration("20190516135900_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SnowFileBar.Domain.FileBarData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColourName");

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.ToTable("FilesData");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColourName = "Red",
                            Size = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}