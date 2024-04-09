using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "TBStorages",
                columns: new[] { "StorageId", "LastUpdate", "PartialQuantity", "ProductId", "WarehouseId" },
                values: new object[] { "79d4b184-b745-44eb-bff3-9945686266c4", new DateTime(2024, 4, 8, 20, 6, 5, 436, DateTimeKind.Utc).AddTicks(5590), 100, "B2", "4ff27e3b-c3e6-4084-b5d0-da2b7f686896" });

            migrationBuilder.InsertData(
                table: "TBWareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[,]
                {
                    { "334c0496-0763-411b-9335-e96fbd87f4b7", "Calle 10 con 11", "Bodega Inferior" },
                    { "9ad65b67-eedc-4bd9-a3be-44a1ca1d3631", "Calle 2 con 38", "Bodega Superior" },
                    { "e26389da-4f29-4fbf-93f4-7598f87102b1", "Calle 8 con 23", "Bodega Central" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TBStorages",
                keyColumn: "StorageId",
                keyValue: "79d4b184-b745-44eb-bff3-9945686266c4");

            migrationBuilder.DeleteData(
                table: "TBWareHouses",
                keyColumn: "WareHouseId",
                keyValue: "334c0496-0763-411b-9335-e96fbd87f4b7");

            migrationBuilder.DeleteData(
                table: "TBWareHouses",
                keyColumn: "WareHouseId",
                keyValue: "9ad65b67-eedc-4bd9-a3be-44a1ca1d3631");

            migrationBuilder.DeleteData(
                table: "TBWareHouses",
                keyColumn: "WareHouseId",
                keyValue: "e26389da-4f29-4fbf-93f4-7598f87102b1");

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
    }
}
