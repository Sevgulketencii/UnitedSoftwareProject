using Microsoft.EntityFrameworkCore.Migrations;

namespace PostApi.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentStatus",
                table: "CommentDbSet",
                newName: "FPostStatus");

            migrationBuilder.RenameColumn(
                name: "CommentDescription",
                table: "CommentDbSet",
                newName: "FPostDescription");

            migrationBuilder.RenameColumn(
                name: "CommentDate",
                table: "CommentDbSet",
                newName: "FPosttDate");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "CommentDbSet",
                newName: "FoodPostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FPosttDate",
                table: "CommentDbSet",
                newName: "CommentDate");

            migrationBuilder.RenameColumn(
                name: "FPostStatus",
                table: "CommentDbSet",
                newName: "CommentStatus");

            migrationBuilder.RenameColumn(
                name: "FPostDescription",
                table: "CommentDbSet",
                newName: "CommentDescription");

            migrationBuilder.RenameColumn(
                name: "FoodPostId",
                table: "CommentDbSet",
                newName: "CommentId");
        }
    }
}
