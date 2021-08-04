using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDataAccess.Migrations
{
    public partial class AddTagNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TagNumber",
                table: "Assets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagNumber",
                table: "Assets");
        }
    }
}
