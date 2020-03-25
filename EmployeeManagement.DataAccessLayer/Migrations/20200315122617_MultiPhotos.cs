using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.DataAccessLayer.Migrations
{
    public partial class MultiPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MultiPhotos",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MultiPhotos",
                table: "Employees");
        }
    }
}
