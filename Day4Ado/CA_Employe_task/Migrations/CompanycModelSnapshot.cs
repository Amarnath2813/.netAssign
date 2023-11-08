﻿// <auto-generated />
using System;
using CA_Employe_task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CA_Employe_task.Migrations
{
    [DbContext(typeof(Companyc))]
    partial class CompanycModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CA_Employe_task.Models.Department", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("DepName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("CA_Employe_task.Models.Employee", b =>
                {
                    b.Property<int?>("EmloyeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("EmloyeeId"));

                    b.Property<int?>("DepId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Salary")
                        .HasColumnType("real");

                    b.HasKey("EmloyeeId");

                    b.HasIndex("DepId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CA_Employe_task.Models.Employee", b =>
                {
                    b.HasOne("CA_Employe_task.Models.Department", "Department")
                        .WithMany("Employee")
                        .HasForeignKey("DepId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CA_Employe_task.Models.Department", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
