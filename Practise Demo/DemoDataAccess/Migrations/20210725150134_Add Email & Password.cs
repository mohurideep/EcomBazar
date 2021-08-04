using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDataAccess.Migrations
{
    public partial class AddEmailPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpPincode",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pincode",
                table: "Employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "EmpPincode",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
