using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTime.DataAccess.Migrations
{
    public partial class TablesFeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("06ffa08f-902b-422d-ad4f-6b657645b98c"), new DateTime(2021, 5, 2, 1, 27, 59, 916, DateTimeKind.Local).AddTicks(4067), "Yabancı Filmler", "Yabancı" },
                    { new Guid("327c43ed-7687-469f-ac27-5f97283dd3d0"), new DateTime(2021, 5, 2, 1, 27, 59, 919, DateTimeKind.Local).AddTicks(2993), "4K Filmler", "4K" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreationDate", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("7a05bc36-9e90-4513-b463-e85e1c6757bd"), new DateTime(2021, 5, 2, 1, 27, 59, 922, DateTimeKind.Local).AddTicks(2820), "Aile Filmleri", "Aile" },
                    { new Guid("3b73b3cd-944c-4f5c-a4c2-c764d17f1681"), new DateTime(2021, 5, 2, 1, 27, 59, 922, DateTimeKind.Local).AddTicks(3431), "Fantastik Filmler", "Fantastik" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreationDate", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("ef19f7e9-13d5-4171-ba03-edd1ed3cc5be"), new DateTime(2021, 5, 2, 1, 27, 59, 923, DateTimeKind.Local).AddTicks(2961), "HarryPotter Tagi", "Harry Potter Serisi" },
                    { new Guid("b419f1b3-2935-4828-82b5-c63eeff081c6"), new DateTime(2021, 5, 2, 1, 27, 59, 923, DateTimeKind.Local).AddTicks(3545), "HarryPotter Tagi2", "Harry Potter Filmleri İzle" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06ffa08f-902b-422d-ad4f-6b657645b98c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("327c43ed-7687-469f-ac27-5f97283dd3d0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3b73b3cd-944c-4f5c-a4c2-c764d17f1681"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7a05bc36-9e90-4513-b463-e85e1c6757bd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b419f1b3-2935-4828-82b5-c63eeff081c6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ef19f7e9-13d5-4171-ba03-edd1ed3cc5be"));
        }
    }
}
