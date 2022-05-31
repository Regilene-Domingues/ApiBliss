using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "QuestionId",
                table: "Choice",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "QuestionsId",
                table: "Choice",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Choice_QuestionsId",
                table: "Choice",
                column: "QuestionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Choice_Question_QuestionsId",
                table: "Choice",
                column: "QuestionsId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choice_Question_QuestionsId",
                table: "Choice");

            migrationBuilder.DropIndex(
                name: "IX_Choice_QuestionsId",
                table: "Choice");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Choice");

            migrationBuilder.DropColumn(
                name: "QuestionsId",
                table: "Choice");
        }
    }
}
