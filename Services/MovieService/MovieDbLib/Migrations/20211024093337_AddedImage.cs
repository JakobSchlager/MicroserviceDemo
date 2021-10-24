using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieDbLib.Migrations
{
    public partial class AddedImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "movie",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/rjkmN1dniUHVYAtwuV3Tji7FsDO.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/lr3cYNDlJcpT1EWzFH42aSIvkab.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/qmJGd5IfURq8iPQ9KF3les47vFS.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/xmbU4JTUm8rsdtn7Y3Fcm30GpeT.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "/2uNW4WbgBXL25BAbXGLnLqX71Sw.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "/k0ThmZQl5nHe4JefC2bXjqtgYp0.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "/xYLBgw7dHyEqmcrSk2Sq3asuSq5.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "/uIXF0sQGXOxQhbaEaKOi2VYlIL0.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "/jxdKa1467pktAILLbfw6kZyQlbW.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "/vFIHbiy55smzi50RmF8LQjmpGcx.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "/xSqtHT2DWbWBZ4dUvvMs6z1OfFK.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "/wIm5S6Blkb0qDMTGVu80VWSrQV1.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "/vGcHyV9s1N2I7bJLSBODvqHTYLL.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "/lNRdCfVcjLs2LhO1Vb5rgnHV4JW.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "/3WfvjNWr5k1Zzww81b3GWc8KQhb.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "/5VJSIAhSn4qUsg5nOj4MhQhF5wQ.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "/1BIoJGKbXjdFDAqUEiA2VHqkK1Z.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "/kb4s0ML0iVZlG6wAKbbs9NAm6X.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "/uWStkK8bq9ixY3fc7y209ZleCoF.jpg");

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "/6Wm7P6y22UZA40QuPYHyWyJ6leI.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "movie");
        }
    }
}
