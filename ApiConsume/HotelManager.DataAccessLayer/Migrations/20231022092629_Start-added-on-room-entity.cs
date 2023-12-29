using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManager.DataAccessLayer.Migrations
{
    public partial class Startaddedonroomentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Start",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Start",
                table: "Rooms");
        }
    }
}
