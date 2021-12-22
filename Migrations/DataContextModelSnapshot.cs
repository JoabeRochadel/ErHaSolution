﻿// <auto-generated />
using System;
using ErHaSolution.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ErHaSolution.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ErHaSolution.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sallary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeCategoryId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ErHaSolution.Models.EmployeeCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Category");

                    b.HasKey("Id");

                    b.ToTable("EmployeeCategory");
                });

            modelBuilder.Entity("ErHaSolution.Models.Employee", b =>
                {
                    b.HasOne("ErHaSolution.Models.EmployeeCategory", "EmployeeCategory")
                        .WithMany()
                        .HasForeignKey("EmployeeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
