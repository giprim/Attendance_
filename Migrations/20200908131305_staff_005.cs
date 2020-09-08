using Microsoft.EntityFrameworkCore.Migrations;

namespace Attendance.Migrations
{
    public partial class staff_005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StaffID",
                table: "Stamp",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "Stamp");
        }
    }
}
