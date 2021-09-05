using Microsoft.EntityFrameworkCore.Migrations;

namespace TrungNhan.Migrations
{
    public partial class Added_Category_UpdateName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTrungNhan",
                table: "AppTrungNhan");

            migrationBuilder.RenameTable(
                name: "AppTrungNhan",
                newName: "AppCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory");

            migrationBuilder.RenameTable(
                name: "AppCategory",
                newName: "AppTrungNhan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTrungNhan",
                table: "AppTrungNhan",
                column: "Id");
        }
    }
}
