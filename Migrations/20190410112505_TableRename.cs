using Microsoft.EntityFrameworkCore.Migrations;

namespace QazATK.Migrations
{
    public partial class TableRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "Patronimyc",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "Enrollee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Enrollee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patronimyc",
                table: "Enrollee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
