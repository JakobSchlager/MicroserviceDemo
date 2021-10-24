using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketDbLib.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "Id", "CustomerName", "PresentationId", "SeatId" },
                values: new object[,]
                {
                    { 1, "Jakob Schlager", 1, 15 },
                    { 2, "Thomas Wahlmüller", 1, 18 },
                    { 3, "Florian Auer", 2, 30 },
                    { 4, "Fabian Graml", 2, 31 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
