﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Private_Practice.DAL;

namespace Private_Practice.Migrations
{
    [DbContext(typeof(PracticeContext))]
    [Migration("20200121064632_Person_conversion")]
    partial class Person_conversion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Private_Practice.Models.Illness", b =>
                {
                    b.Property<Guid>("IllnessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IllnessName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IllnessId");

                    b.ToTable("Illnesses");
                });

            modelBuilder.Entity("Private_Practice.Models.Person", b =>
                {
                    b.Property<Guid>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("ContactNo")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("IdNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Private_Practice.Models.Visit", b =>
                {
                    b.Property<Guid>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VisitId");

                    b.HasIndex("ClientId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Visit");
                });

            modelBuilder.Entity("Private_Practice.Models.Client", b =>
                {
                    b.HasBaseType("Private_Practice.Models.Person");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IllnessId")
                        .HasColumnType("uniqueidentifier");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Private_Practice.Models.Doctor", b =>
                {
                    b.HasBaseType("Private_Practice.Models.Person");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Specialist")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("Private_Practice.Models.Visit", b =>
                {
                    b.HasOne("Private_Practice.Models.Client", null)
                        .WithMany("Visits")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Private_Practice.Models.Doctor", null)
                        .WithMany("Visits")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
