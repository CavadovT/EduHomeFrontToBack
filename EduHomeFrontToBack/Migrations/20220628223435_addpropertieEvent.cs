using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeFrontToBack.Migrations
{
    public partial class addpropertieEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Events");
        }
    }
}
