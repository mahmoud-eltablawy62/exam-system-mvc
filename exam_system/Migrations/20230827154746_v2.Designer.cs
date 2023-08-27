﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exam_system.Models;

#nullable disable

namespace exam_system.Migrations
{
    [DbContext(typeof(ExamContext))]
    [Migration("20230827154746_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("exam_system.Models.Instractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("instractors");
                });

            modelBuilder.Entity("exam_system.Models.Questions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("answer_stud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("head")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ins_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ins_id");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("exam_system.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("choice")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("grade")
                        .HasColumnType("int");

                    b.Property<int?>("ins_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("email")
                        .IsUnique();

                    b.HasIndex("ins_id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("exam_system.Models.Questions", b =>
                {
                    b.HasOne("exam_system.Models.Instractor", "Ins")
                        .WithMany("Ques")
                        .HasForeignKey("ins_id");

                    b.Navigation("Ins");
                });

            modelBuilder.Entity("exam_system.Models.Student", b =>
                {
                    b.HasOne("exam_system.Models.Instractor", "ins")
                        .WithMany("students")
                        .HasForeignKey("ins_id");

                    b.Navigation("ins");
                });

            modelBuilder.Entity("exam_system.Models.Instractor", b =>
                {
                    b.Navigation("Ques");

                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}