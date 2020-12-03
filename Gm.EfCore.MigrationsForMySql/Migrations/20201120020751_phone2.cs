using Microsoft.EntityFrameworkCore.Migrations;

namespace Gm.EfCore.MigrationsForMySql.Migrations
{
    public partial class phone2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Account");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber2",
                table: "Account",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber2",
                table: "Account");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Account",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
