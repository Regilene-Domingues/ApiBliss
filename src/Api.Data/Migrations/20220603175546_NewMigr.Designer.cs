﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220603175546_NewMigr")]
    partial class NewMigr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.ChoiceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Choice")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("QuestionEntityId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Choice");

                    b.HasIndex("QuestionEntityId");

                    b.ToTable("Choice");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Choice = "Choice 1",
                            DateCreate = new DateTime(2022, 6, 3, 14, 55, 46, 457, DateTimeKind.Local).AddTicks(4418),
                            QuestionId = 1
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.QuestionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Question");

                    b.ToTable("Question");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreate = new DateTime(2022, 6, 3, 14, 55, 46, 454, DateTimeKind.Local).AddTicks(9592),
                            Question = "Question 1"
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.ChoiceEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.QuestionEntity", null)
                        .WithMany("Choice")
                        .HasForeignKey("QuestionEntityId");
                });
#pragma warning restore 612, 618
        }
    }
}