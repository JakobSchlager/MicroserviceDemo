﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomDbLib.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "room",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Display: 3D, UHD" },
                    { 2, "Display: 3D" },
                    { 3, "Display: 3D, UHD" },
                    { 4, "Display: 3D, UHD" },
                    { 5, "Display: 4D" }
                });

            migrationBuilder.InsertData(
                table: "seat",
                columns: new[] { "Id", "Description", "RoomId" },
                values: new object[,]
                {
                    { 1, "single Seat", 1 },
                    { 97, "single Seat", 4 },
                    { 98, "single Seat", 4 },
                    { 99, "single Seat", 4 },
                    { 100, "single Seat", 4 },
                    { 101, "single Seat", 4 },
                    { 102, "single Seat", 4 },
                    { 96, "single Seat", 4 },
                    { 103, "single Seat", 4 },
                    { 105, "single Seat", 4 },
                    { 106, "single Seat", 4 },
                    { 107, "single Seat", 4 },
                    { 108, "single Seat", 4 },
                    { 109, "single Seat", 4 },
                    { 110, "single Seat", 4 },
                    { 104, "single Seat", 4 },
                    { 95, "single Seat", 3 },
                    { 94, "single Seat", 3 },
                    { 93, "single Seat", 3 },
                    { 78, "single Seat", 3 },
                    { 79, "single Seat", 3 },
                    { 80, "single Seat", 3 },
                    { 81, "single Seat", 3 },
                    { 82, "single Seat", 3 },
                    { 83, "single Seat", 3 },
                    { 84, "single Seat", 3 },
                    { 85, "single Seat", 3 },
                    { 86, "single Seat", 3 },
                    { 87, "single Seat", 3 },
                    { 88, "single Seat", 3 },
                    { 89, "single Seat", 3 },
                    { 90, "single Seat", 3 },
                    { 91, "single Seat", 3 },
                    { 92, "single Seat", 3 },
                    { 111, "single Seat", 5 },
                    { 112, "single Seat", 5 },
                    { 113, "single Seat", 5 },
                    { 114, "single Seat", 5 },
                    { 134, "single Seat", 5 },
                    { 135, "single Seat", 5 },
                    { 136, "single Seat", 5 },
                    { 137, "single Seat", 5 },
                    { 138, "single Seat", 5 },
                    { 139, "single Seat", 5 },
                    { 140, "single Seat", 5 },
                    { 141, "single Seat", 5 },
                    { 142, "single Seat", 5 },
                    { 143, "single Seat", 5 },
                    { 144, "single Seat", 5 },
                    { 145, "single Seat", 5 },
                    { 146, "single Seat", 5 },
                    { 147, "single Seat", 5 },
                    { 148, "single Seat", 5 },
                    { 133, "single Seat", 5 },
                    { 77, "single Seat", 3 },
                    { 132, "single Seat", 5 },
                    { 130, "single Seat", 5 },
                    { 115, "single Seat", 5 },
                    { 116, "single Seat", 5 },
                    { 117, "single Seat", 5 },
                    { 118, "single Seat", 5 },
                    { 119, "single Seat", 5 },
                    { 120, "single Seat", 5 },
                    { 121, "single Seat", 5 },
                    { 122, "single Seat", 5 },
                    { 123, "single Seat", 5 },
                    { 124, "single Seat", 5 },
                    { 125, "single Seat", 5 },
                    { 126, "single Seat", 5 },
                    { 127, "single Seat", 5 },
                    { 128, "single Seat", 5 },
                    { 129, "single Seat", 5 },
                    { 131, "single Seat", 5 },
                    { 76, "single Seat", 3 },
                    { 75, "single Seat", 3 },
                    { 74, "single Seat", 3 },
                    { 21, "single Seat", 2 },
                    { 22, "single Seat", 2 },
                    { 23, "single Seat", 2 },
                    { 24, "single Seat", 2 },
                    { 25, "single Seat", 2 },
                    { 26, "single Seat", 2 },
                    { 27, "single Seat", 2 },
                    { 28, "single Seat", 2 },
                    { 29, "single Seat", 2 },
                    { 30, "single Seat", 2 },
                    { 31, "single Seat", 2 },
                    { 32, "single Seat", 2 },
                    { 33, "single Seat", 2 },
                    { 34, "single Seat", 2 },
                    { 35, "single Seat", 2 },
                    { 20, "single Seat", 1 },
                    { 36, "single Seat", 2 },
                    { 19, "single Seat", 1 },
                    { 17, "single Seat", 1 },
                    { 2, "single Seat", 1 },
                    { 3, "single Seat", 1 },
                    { 4, "single Seat", 1 },
                    { 5, "single Seat", 1 },
                    { 6, "single Seat", 1 },
                    { 7, "single Seat", 1 },
                    { 8, "single Seat", 1 },
                    { 9, "single Seat", 1 },
                    { 10, "single Seat", 1 },
                    { 11, "single Seat", 1 },
                    { 12, "single Seat", 1 },
                    { 13, "single Seat", 1 },
                    { 14, "single Seat", 1 },
                    { 15, "single Seat", 1 },
                    { 16, "single Seat", 1 },
                    { 18, "single Seat", 1 },
                    { 149, "single Seat", 5 },
                    { 37, "single Seat", 2 },
                    { 39, "single Seat", 2 },
                    { 59, "single Seat", 2 },
                    { 60, "single Seat", 2 },
                    { 61, "single Seat", 3 },
                    { 62, "single Seat", 3 },
                    { 63, "single Seat", 3 },
                    { 64, "single Seat", 3 },
                    { 65, "single Seat", 3 },
                    { 66, "single Seat", 3 },
                    { 67, "single Seat", 3 },
                    { 68, "single Seat", 3 },
                    { 69, "single Seat", 3 },
                    { 70, "single Seat", 3 },
                    { 71, "single Seat", 3 },
                    { 72, "single Seat", 3 },
                    { 73, "single Seat", 3 },
                    { 58, "single Seat", 2 },
                    { 38, "single Seat", 2 },
                    { 57, "single Seat", 2 },
                    { 55, "single Seat", 2 },
                    { 40, "single Seat", 2 },
                    { 41, "single Seat", 2 },
                    { 42, "single Seat", 2 },
                    { 43, "single Seat", 2 },
                    { 44, "single Seat", 2 },
                    { 45, "single Seat", 2 },
                    { 46, "single Seat", 2 },
                    { 47, "single Seat", 2 },
                    { 48, "single Seat", 2 },
                    { 49, "single Seat", 2 },
                    { 50, "single Seat", 2 },
                    { 51, "single Seat", 2 },
                    { 52, "single Seat", 2 },
                    { 53, "single Seat", 2 },
                    { 54, "single Seat", 2 },
                    { 56, "single Seat", 2 },
                    { 150, "single Seat", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_seat_RoomId",
                table: "seat",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
