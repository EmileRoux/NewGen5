using Microsoft.EntityFrameworkCore.Migrations;

namespace NewGen5Razor.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Vendors");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Vendors",
                newName: "VendorsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendors",
                table: "Vendors",
                column: "VendorsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendors",
                table: "Vendors");

            migrationBuilder.RenameTable(
                name: "Vendors",
                newName: "Movie");

            migrationBuilder.RenameColumn(
                name: "VendorsID",
                table: "Movie",
                newName: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "ID");
        }
    }
}
