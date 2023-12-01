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
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("blocking")
                        .HasColumnType("INTEGER");

                    b.Property<int>("catching")
                        .HasColumnType("INTEGER");

                    b.Property<int>("kicking")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("ovr")
                        .HasColumnType("INTEGER");

                    b.Property<int>("passing")
                        .HasColumnType("INTEGER");

                    b.Property<int>("primaryDefPos")
                        .HasColumnType("INTEGER");

                    b.Property<int>("primaryOffPos")
                        .HasColumnType("INTEGER");

                    b.Property<int>("primarySpePos")
                        .HasColumnType("INTEGER");

                    b.Property<int>("running")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Player");
                });
#pragma warning restore 612, 618
        }
    }
}