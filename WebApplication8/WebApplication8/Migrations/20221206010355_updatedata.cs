using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication8.Migrations
{
    public partial class updatedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AboutPerson_PersonId",
                table: "AboutPerson");

            migrationBuilder.CreateIndex(
                name: "IX_AboutPerson_PersonId",
                table: "AboutPerson",
                column: "PersonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AboutPerson_PersonId",
                table: "AboutPerson");

            migrationBuilder.CreateIndex(
                name: "IX_AboutPerson_PersonId",
                table: "AboutPerson",
                column: "PersonId");
        }
    }
}
