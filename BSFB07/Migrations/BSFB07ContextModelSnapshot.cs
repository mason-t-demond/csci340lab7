﻿// <auto-generated />
using BSFB07.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BSFB07.Migrations
{
    [DbContext(typeof(BSFB07Context))]
    partial class BSFB07ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("BSFB07.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Blocking")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Catching")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kicking")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ovr")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Passing")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Running")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("primaryDefPos")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("primaryOffPos")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("primarySpePos")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });
#pragma warning restore 612, 618
        }
    }
}
