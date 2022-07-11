using Microsoft.EntityFrameworkCore.Migrations;

namespace Task.Migrations
{
    public partial class changeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professions_Professions_ProfessionId",
                table: "Professions");

            migrationBuilder.DropIndex(
                name: "IX_Professions_ProfessionId",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "Professions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessionId",
                table: "Professions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professions_ProfessionId",
                table: "Professions",
                column: "ProfessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professions_Professions_ProfessionId",
                table: "Professions",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
