using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class NewMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    Question = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Choice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    Choice = table.Column<string>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    QuestionEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Choice_Question_QuestionEntityId",
                        column: x => x.QuestionEntityId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Choice",
                columns: new[] { "Id", "Choice", "DateCreate", "DateUpdate", "QuestionEntityId", "QuestionId" },
                values: new object[] { 1, "Choice 1", new DateTime(2022, 6, 3, 14, 55, 46, 457, DateTimeKind.Local).AddTicks(4418), null, null, 1 });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "Question" },
                values: new object[] { 1, new DateTime(2022, 6, 3, 14, 55, 46, 454, DateTimeKind.Local).AddTicks(9592), null, "Question 1" });

            migrationBuilder.CreateIndex(
                name: "IX_Choice_Choice",
                table: "Choice",
                column: "Choice");

            migrationBuilder.CreateIndex(
                name: "IX_Choice_QuestionEntityId",
                table: "Choice",
                column: "QuestionEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_Question",
                table: "Question",
                column: "Question");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Choice");

            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
