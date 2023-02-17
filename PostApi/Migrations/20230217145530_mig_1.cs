using Microsoft.EntityFrameworkCore.Migrations;

namespace PostApi.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodPostTitle",
                table: "FoodPostDbSet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodPostTitle",
                table: "FoodPostDbSet");
        }
    }
}
