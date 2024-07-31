﻿// <auto-generated />
using ExampleFluentAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExampleFluentAPI.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20240731081354_dddd2")]
    partial class dddd2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Admin")
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExampleFluentAPI.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees", "Admin");
                });

            modelBuilder.Entity("ExampleFluentAPI.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StandardId"));

                    b.Property<string>("StandardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StandardId");

                    b.ToTable("StandardInfo", "dbo");
                });

            modelBuilder.Entity("ExampleFluentAPI.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<int>("StandardId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(233)
                        .HasColumnType("nvarchar")
                        .HasColumnName("name")
                        .HasColumnOrder(3)
                        .IsFixedLength();

                    b.HasKey("StudentID");

                    b.HasIndex("StandardId");

                    b.ToTable("StudentInfo", "Admin");
                });

            modelBuilder.Entity("ExampleFluentAPI.Student", b =>
                {
                    b.HasOne("ExampleFluentAPI.Standard", "Standard")
                        .WithMany("Students")
                        .HasForeignKey("StandardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Standard");
                });

            modelBuilder.Entity("ExampleFluentAPI.Standard", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
