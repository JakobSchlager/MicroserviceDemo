using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieDbLib.Migrations
{
    public partial class AddedDefaultPresentation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "presentation",
                columns: new[] { "Id", "MovieId", "RoomId", "StartTime" },
                values: new object[] { 1, 1, 1, "25.10.2021 00:00:00" });

            migrationBuilder.InsertData(
                table: "presentation",
                columns: new[] { "Id", "MovieId", "RoomId", "StartTime" },
                values: new object[] { 2, 2, 2, "26.10.2021 00:00:00" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "presentation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "presentation",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
