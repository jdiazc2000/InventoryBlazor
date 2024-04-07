using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TBCategories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumería" },
                    { "SLD", "Salud" },
                    { "VDJ", "Video Juegos" }
                });

            migrationBuilder.InsertData(
                table: "TBWareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[,]
                {
                    { "16bf72a2-feb4-4f76-8a88-5e9cbdcc921a", "Calle 2 con 38", "Bodega Superior" },
                    { "4ff27e3b-c3e6-4084-b5d0-da2b7f686896", "Calle 8 con 23", "Bodega Central" },
                    { "e9a4da00-4d4c-445d-80c8-dc86170fc81b", "Calle 10 con 11", "Bodega Inferior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TBCategories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "TBCategories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "TBCategories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "TBCategories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "TBCategories",
                keyColumn: "CategoryId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "TBCategories",
                keyColumn: "CategoryId",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "TBWareHouses",
                keyColumn: "WareHouseId",
                keyValue: "16bf72a2-feb4-4f76-8a88-5e9cbdcc921a");

            migrationBuilder.DeleteData(
                table: "TBWareHouses",
                keyColumn: "WareHouseId",
                keyValue: "4ff27e3b-c3e6-4084-b5d0-da2b7f686896");

            migrationBuilder.DeleteData(
                table: "TBWareHouses",
                keyColumn: "WareHouseId",
                keyValue: "e9a4da00-4d4c-445d-80c8-dc86170fc81b");
        }
    }
}
