using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UPMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 435, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.InsertData(
                table: "Choice",
                columns: new[] { "Id", "Choice", "DateCreate", "DateUpdate", "QuestionEntityId", "QuestionId" },
                values: new object[,]
                {
                    { 15, "Choice 15", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(320), null, null, 15 },
                    { 14, "Choice 14", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(318), null, null, 14 },
                    { 13, "Choice 13", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(315), null, null, 13 },
                    { 12, "Choice 12", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(313), null, null, 12 },
                    { 11, "Choice 11", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(310), null, null, 11 },
                    { 10, "Choice 10", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(308), null, null, 10 },
                    { 2, "Choice 2", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(262), null, null, 2 },
                    { 8, "Choice 8", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(303), null, null, 8 },
                    { 7, "Choice 7", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(300), null, null, 7 },
                    { 6, "Choice 6", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(298), null, null, 6 },
                    { 5, "Choice 5", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(295), null, null, 5 },
                    { 4, "Choice 4", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(293), null, null, 4 },
                    { 3, "Choice 3", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(289), null, null, 3 },
                    { 9, "Choice 9", new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(305), null, null, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 431, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "Question" },
                values: new object[,]
                {
                    { 15, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4172), null, "Question 15" },
                    { 14, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4170), null, "Question 14" },
                    { 13, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4167), null, "Question 13" },
                    { 12, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4164), null, "Question 12" },
                    { 11, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4161), null, "Question 11" },
                    { 10, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4159), null, "Question 10" },
                    { 6, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4149), null, "Question 6" },
                    { 8, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4154), null, "Question 8" },
                    { 7, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4151), null, "Question 7" },
                    { 5, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4146), null, "Question 5" },
                    { 4, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4143), null, "Question 4" },
                    { 3, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4139), null, "Question 3" },
                    { 9, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4156), null, "Question 9" },
                    { 2, new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4070), null, "Question 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 14, 55, 46, 457, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 14, 55, 46, 454, DateTimeKind.Local).AddTicks(9592));
        }
    }
}
