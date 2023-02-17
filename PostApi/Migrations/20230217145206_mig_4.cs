using Microsoft.EntityFrameworkCore.Migrations;

namespace PostApi.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentDbSet_PostDbSet_postId",
                table: "CommentDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentDbSet",
                table: "CommentDbSet");

            migrationBuilder.RenameTable(
                name: "CommentDbSet",
                newName: "FoodPostDbSet");

            migrationBuilder.RenameIndex(
                name: "IX_CommentDbSet_postId",
                table: "FoodPostDbSet",
                newName: "IX_FoodPostDbSet_postId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodPostDbSet",
                table: "FoodPostDbSet",
                column: "FoodPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodPostDbSet_PostDbSet_postId",
                table: "FoodPostDbSet",
                column: "postId",
                principalTable: "PostDbSet",
                principalColumn: "postId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodPostDbSet_PostDbSet_postId",
                table: "FoodPostDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodPostDbSet",
                table: "FoodPostDbSet");

            migrationBuilder.RenameTable(
                name: "FoodPostDbSet",
                newName: "CommentDbSet");

            migrationBuilder.RenameIndex(
                name: "IX_FoodPostDbSet_postId",
                table: "CommentDbSet",
                newName: "IX_CommentDbSet_postId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentDbSet",
                table: "CommentDbSet",
                column: "FoodPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentDbSet_PostDbSet_postId",
                table: "CommentDbSet",
                column: "postId",
                principalTable: "PostDbSet",
                principalColumn: "postId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
