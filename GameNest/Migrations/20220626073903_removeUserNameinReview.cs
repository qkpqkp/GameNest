using Microsoft.EntityFrameworkCore.Migrations;

namespace GameNest.Migrations
{
    public partial class removeUserNameinReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Reviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
