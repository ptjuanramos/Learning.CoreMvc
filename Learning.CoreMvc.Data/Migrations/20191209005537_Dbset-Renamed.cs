using Microsoft.EntityFrameworkCore.Migrations;

namespace Learning.CoreMvc.Data.Migrations
{
    public partial class DbsetRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDbSet",
                table: "UserDbSet");

            migrationBuilder.RenameTable(
                name: "UserDbSet",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "UserDbSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDbSet",
                table: "UserDbSet",
                column: "Id");
        }
    }
}
