﻿// <auto-generated />
using System;
using AnimatLabs.Infrastructure.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.DataSetup.Development.Migrations
{
    [DbContext(typeof(HogwartsDbContext))]
    [Migration("20220807151128_dev.1.0.2")]
    partial class dev102
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AnimatLabs.Infrastructure.Data.DataAccess.Course", b =>
                {
                    b.Property<Guid>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("578c9088-d00d-421f-b418-bb3e305fa32f"),
                            Credits = 5,
                            Title = "Defense Against the Dark Arts",
                            Year = 1
                        },
                        new
                        {
                            CourseId = new Guid("24e42ce8-6d38-4c5d-88e8-8310935bd886"),
                            Credits = 2,
                            Title = "Alchemy",
                            Year = 2
                        },
                        new
                        {
                            CourseId = new Guid("680b9bd7-cae9-4126-9b22-2c700fbab340"),
                            Credits = 3,
                            Title = "Beasts",
                            Year = 3
                        });
                });

            modelBuilder.Entity("AnimatLabs.Infrastructure.Data.DataAccess.Enrollment", b =>
                {
                    b.Property<Guid>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("StudentId");

                    b.HasIndex(new[] { "CourseId", "StudentId" }, "IX_Course_Student");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("AnimatLabs.Infrastructure.Data.DataAccess.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("House")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AnimatLabs.Infrastructure.Data.DataAccess.Enrollment", b =>
                {
                    b.HasOne("AnimatLabs.Infrastructure.Data.DataAccess.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimatLabs.Infrastructure.Data.DataAccess.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("AnimatLabs.Infrastructure.Data.DataAccess.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("AnimatLabs.Infrastructure.Data.DataAccess.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
