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
    [Migration("20230814125649_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("exam_system.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("exams");
                });

            modelBuilder.Entity("exam_system.Models.Exam_Student", b =>
                {
                    b.Property<int>("Ex_Id")
                        .HasColumnType("int");

                    b.Property<int>("Stu_Id")
                        .HasColumnType("int");

                    b.HasKey("Ex_Id", "Stu_Id");

                    b.HasIndex("Stu_Id");

                    b.ToTable("exam_Students");
                });

            modelBuilder.Entity("exam_system.Models.Ins_Stud", b =>
                {
                    b.Property<int>("Stud_Id")
                        .HasColumnType("int");

                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.HasKey("Stud_Id", "Ins_Id");

                    b.HasIndex("Ins_Id");

                    b.ToTable("ins_studs");
                });

            modelBuilder.Entity("exam_system.Models.Instractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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

                    b.Property<string>("body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("exam_id")
                        .HasColumnType("int");

                    b.Property<string>("head")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ins_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("exam_id");

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

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("grade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("email")
                        .IsUnique();

                    b.ToTable("students");
                });

            modelBuilder.Entity("exam_system.Models.Exam_Student", b =>
                {
                    b.HasOne("exam_system.Models.Exam", "exams")
                        .WithMany()
                        .HasForeignKey("Ex_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("exam_system.Models.Student", "stds")
                        .WithMany()
                        .HasForeignKey("Stu_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exams");

                    b.Navigation("stds");
                });

            modelBuilder.Entity("exam_system.Models.Ins_Stud", b =>
                {
                    b.HasOne("exam_system.Models.Instractor", "Incs")
                        .WithMany("ins_studs")
                        .HasForeignKey("Ins_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("exam_system.Models.Student", "Studs")
                        .WithMany("ins_studs")
                        .HasForeignKey("Stud_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incs");

                    b.Navigation("Studs");
                });

            modelBuilder.Entity("exam_system.Models.Questions", b =>
                {
                    b.HasOne("exam_system.Models.Exam", "Exams")
                        .WithMany()
                        .HasForeignKey("exam_id");

                    b.HasOne("exam_system.Models.Instractor", "Ins")
                        .WithMany("Ques")
                        .HasForeignKey("ins_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exams");

                    b.Navigation("Ins");
                });

            modelBuilder.Entity("exam_system.Models.Instractor", b =>
                {
                    b.Navigation("Ques");

                    b.Navigation("ins_studs");
                });

            modelBuilder.Entity("exam_system.Models.Student", b =>
                {
                    b.Navigation("ins_studs");
                });
#pragma warning restore 612, 618
        }
    }
}