﻿// <auto-generated />
using EFCore.PL.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.PL.Migrations
{
    [DbContext(typeof(ApplecationDbContext))]
    [Migration("20240714211035_AddSalaryCheckConstrain")]
    partial class AddSalaryCheckConstrain
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore.PL.Models.Department", b =>
                {
                    b.Property<byte>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasAnnotation("SqlServer:Identity", "1, 1");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("DepartmentId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EFCore.PL.Models.Employee", b =>
                {
                    b.Property<byte>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("EmployeeId")
                        .HasAnnotation("SqlServer:Identity", "1, 1");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("EmployeeId"));

                    b.Property<byte>("DepartmentId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Email")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("NewSalary")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("decimal(18,2)")
                        .HasComputedColumnSql("(([Salary] * 0.05) + [Salary])");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<decimal>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,2)")
                        .HasDefaultValue(3000m);

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeId")
                        .HasDatabaseName("IN_EmployeeId");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Employees", t =>
                        {
                            t.HasCheckConstraint("CK_Salary", "[Salary] between 1000 and 8000");
                        });
                });

            modelBuilder.Entity("EFCore.PL.Models.Employee", b =>
                {
                    b.HasOne("EFCore.PL.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EFCore.PL.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}