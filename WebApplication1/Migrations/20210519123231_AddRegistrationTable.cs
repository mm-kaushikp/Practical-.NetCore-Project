using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddRegistrationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_registrations",
                table: "registrations");

            migrationBuilder.RenameTable(
                name: "registrations",
                newName: "RegistrationTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistrationTable",
                table: "RegistrationTable",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistrationTable",
                table: "RegistrationTable");

            migrationBuilder.RenameTable(
                name: "RegistrationTable",
                newName: "registrations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_registrations",
                table: "registrations",
                column: "UserID");
        }
    }
}
