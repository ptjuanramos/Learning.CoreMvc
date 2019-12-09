using Microsoft.EntityFrameworkCore.Migrations;

namespace Learning.CoreMvc.Data.Migrations
{
    public partial class CleaningTests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email2",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email2",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
