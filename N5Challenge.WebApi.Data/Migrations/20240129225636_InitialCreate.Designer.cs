﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using N5Company.WebApi.Data;

#nullable disable

namespace N5Challenge.WebApi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240129225636_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("N5Challenge.WebApi.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PermissionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PermissionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PermissionTypeId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("N5Challenge.WebApi.Models.PermissionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PermissionTypes");
                });

            modelBuilder.Entity("N5Challenge.WebApi.Models.Permission", b =>
                {
                    b.HasOne("N5Challenge.WebApi.Models.PermissionType", "PermissionType")
                        .WithMany("Permissions")
                        .HasForeignKey("PermissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermissionType");
                });

            modelBuilder.Entity("N5Challenge.WebApi.Models.PermissionType", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
