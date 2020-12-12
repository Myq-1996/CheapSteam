﻿// <auto-generated />
using System;
using ChpStmScraper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChpStmScraper.Migrations
{
    [DbContext(typeof(ScraperDbContext))]
    partial class ScraperDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ChpStmScraper.Models.Goods", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("BuffBuyPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("BuffSellNum")
                        .HasColumnType("INTEGER");

                    b.Property<double>("BuffSellPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("Kind")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SteamBuyPrice")
                        .HasColumnType("REAL");

                    b.Property<double>("SteamBuyRadio")
                        .HasColumnType("REAL");

                    b.Property<int>("SteamSellNum")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SteamSellPrice")
                        .HasColumnType("REAL");

                    b.Property<double>("SteamSellRadio")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Goods");
                });
#pragma warning restore 612, 618
        }
    }
}