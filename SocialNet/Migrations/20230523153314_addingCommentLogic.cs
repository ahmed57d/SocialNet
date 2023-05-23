using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialNet.Migrations
{
    public partial class addingCommentLogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Comments",
                newName: "CommenterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommenterId",
                table: "Comments",
                newName: "UserId");
        }
    }
}
