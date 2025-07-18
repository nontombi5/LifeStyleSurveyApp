﻿// <auto-generated />
using System;
using LifestyleSurveyApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LifestyleSurveyApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250605173621_updatesurveytable")]
    partial class updatesurveytable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LifestyleSurveyApp.Models.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("EatOut")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ListenToRadio")
                        .HasColumnType("int");

                    b.Property<bool>("Other")
                        .HasColumnType("bit");

                    b.Property<bool>("PapAndWors")
                        .HasColumnType("bit");

                    b.Property<bool>("Pasta")
                        .HasColumnType("bit");

                    b.Property<bool>("Pizza")
                        .HasColumnType("bit");

                    b.Property<int>("WatchMovies")
                        .HasColumnType("int");

                    b.Property<int>("WatchTV")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Survey");
                });
#pragma warning restore 612, 618
        }
    }
}
