using Microsoft.EntityFrameworkCore.Migrations;

namespace PostApi.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodPostDbSet_PostDbSet_postId",
                table: "FoodPostDbSet");

            migrationBuilder.RenameColumn(
                name: "postId",
                table: "FoodPostDbSet",
                newName: "Postid");

            migrationBuilder.RenameIndex(
                name: "IX_FoodPostDbSet_postId",
                table: "FoodPostDbSet",
                newName: "IX_FoodPostDbSet_Postid");

            migrationBuilder.AlterColumn<int>(
                name: "Postid",
                table: "FoodPostDbSet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FoodPostTitle",
                table: "FoodPostDbSet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodPostDbSet_PostDbSet_Postid",
                table: "FoodPostDbSet",
                column: "Postid",
                principalTable: "PostDbSet",
                principalColumn: "postId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodPostDbSet_PostDbSet_Postid",
                table: "FoodPostDbSet");

            migrationBuilder.RenameColumn(
                name: "Postid",
                table: "FoodPostDbSet",
                newName: "postId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodPostDbSet_Postid",
                table: "FoodPostDbSet",
                newName: "IX_FoodPostDbSet_postId");

            migrationBuilder.AlterColumn<int>(
                name: "postId",
                table: "FoodPostDbSet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FoodPostTitle",
                table: "FoodPostDbSet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodPostDbSet_PostDbSet_postId",
                table: "FoodPostDbSet",
                column: "postId",
                principalTable: "PostDbSet",
                principalColumn: "postId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
