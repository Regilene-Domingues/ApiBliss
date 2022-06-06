﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9275),
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Choice = "Choice 2",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9667),
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 3,
                            Choice = "Choice 3",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9683),
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 4,
                            Choice = "Choice 4",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9686),
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 5,
                            Choice = "Choice 5",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9688),
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 6,
                            Choice = "Choice 6",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9690),
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 7,
                            Choice = "Choice 7",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9691),
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 8,
                            Choice = "Choice 8",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9693),
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 9,
                            Choice = "Choice 9",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9695),
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 10,
                            Choice = "Choice 10",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9697),
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 11,
                            Choice = "Choice 11",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9699),
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 12,
                            Choice = "Choice 12",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9700),
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 13,
                            Choice = "Choice 13",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9702),
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 14,
                            Choice = "Choice 14",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9704),
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 15,
                            Choice = "Choice 15",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9706),
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 16,
                            Choice = "Choice 15.1",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9707),
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 17,
                            Choice = "Choice 15.2",
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9709),
                            QuestionId = 15
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
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 346, DateTimeKind.Local).AddTicks(4631),
                            Question = "Question 1"
                        },
                        new
                        {
                            Id = 2,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6002),
                            Question = "Question 2"
                        },
                        new
                        {
                            Id = 3,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6035),
                            Question = "Question 3"
                        },
                        new
                        {
                            Id = 4,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6038),
                            Question = "Question 4"
                        },
                        new
                        {
                            Id = 5,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6040),
                            Question = "Question 5"
                        },
                        new
                        {
                            Id = 6,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6041),
                            Question = "Question 6"
                        },
                        new
                        {
                            Id = 7,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6044),
                            Question = "Question 7"
                        },
                        new
                        {
                            Id = 8,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6045),
                            Question = "Question 8"
                        },
                        new
                        {
                            Id = 9,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6047),
                            Question = "Question 9"
                        },
                        new
                        {
                            Id = 10,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6049),
                            Question = "Question 10"
                        },
                        new
                        {
                            Id = 11,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6050),
                            Question = "Question 11"
                        },
                        new
                        {
                            Id = 12,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6052),
                            Question = "Question 12"
                        },
                        new
                        {
                            Id = 13,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6054),
                            Question = "Question 13"
                        },
                        new
                        {
                            Id = 14,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6056),
                            Question = "Question 14"
                        },
                        new
                        {
                            Id = 15,
                            DateCreate = new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6058),
                            Question = "Question 15"
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
