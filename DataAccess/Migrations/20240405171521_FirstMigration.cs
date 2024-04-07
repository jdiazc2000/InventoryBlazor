using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBCategories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TBWareHouses",
                columns: table => new
                {
                    WareHouseId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WareHouseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WareHouseAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBWareHouses", x => x.WareHouseId);
                });

            migrationBuilder.CreateTable(
                name: "TBProducts",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBProducts", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_TBProducts_TBCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TBCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBStorages",
                columns: table => new
                {
                    StorageId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    PartialQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    WarehouseId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBStorages", x => x.StorageId);
                    table.ForeignKey(
                        name: "FK_TBStorages_TBProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TBProducts",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBStorages_TBWareHouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "TBWareHouses",
                        principalColumn: "WareHouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBInputOutputs",
                columns: table => new
                {
                    InOutId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsInput = table.Column<bool>(type: "bit", nullable: false),
                    StorageId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBInputOutputs", x => x.InOutId);
                    table.ForeignKey(
                        name: "FK_TBInputOutputs_TBStorages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "TBStorages",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBInputOutputs_StorageId",
                table: "TBInputOutputs",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_TBProducts_CategoryId",
                table: "TBProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TBStorages_ProductId",
                table: "TBStorages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TBStorages_WarehouseId",
                table: "TBStorages",
                column: "WarehouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBInputOutputs");

            migrationBuilder.DropTable(
                name: "TBStorages");

            migrationBuilder.DropTable(
                name: "TBProducts");

            migrationBuilder.DropTable(
                name: "TBWareHouses");

            migrationBuilder.DropTable(
                name: "TBCategories");
        }
    }
}
