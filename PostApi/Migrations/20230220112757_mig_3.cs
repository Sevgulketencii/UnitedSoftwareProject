using Microsoft.EntityFrameworkCore.Migrations;

namespace PostApi.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fpostid",
                table: "FoodPostDbSet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fpostid",
                table: "FoodPostDbSet");
        }
    }
}
