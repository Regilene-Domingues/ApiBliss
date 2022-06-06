using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class datamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.InsertData(
                table: "Choice",
                columns: new[] { "Id", "Choice", "DateCreate", "DateUpdate", "QuestionEntityId", "QuestionId" },
                values: new object[,]
                {
                    { 16, "Choice 15.1", new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9707), null, null, 15 },
                    { 17, "Choice 15.2", new DateTime(2022, 6, 6, 15, 36, 32, 348, DateTimeKind.Local).AddTicks(9709), null, null, 15 }
                });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 346, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2022, 6, 6, 15, 36, 32, 347, DateTimeKind.Local).AddTicks(6058));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 435, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Choice",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 436, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 431, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2022, 6, 3, 15, 47, 19, 433, DateTimeKind.Local).AddTicks(4172));
        }
    }
}
