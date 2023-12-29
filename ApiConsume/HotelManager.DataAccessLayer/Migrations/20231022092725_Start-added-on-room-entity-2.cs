using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManager.DataAccessLayer.Migrations
{
    public partial class Startaddedonroomentity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Start",
                table: "Rooms",
                newName: "StarCount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StarCount",
                table: "Rooms",
                newName: "Start");
        }
    }
}
