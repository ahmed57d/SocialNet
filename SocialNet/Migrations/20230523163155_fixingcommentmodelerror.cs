using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialNet.Migrations
{
    public partial class fixingcommentmodelerror : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Post",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Post",
                table: "Comments");
        }
    }
}
