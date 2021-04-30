using Microsoft.EntityFrameworkCore.Migrations;

namespace VagnersStore.Server.Migrations
{
    public partial class ProductVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditionProduct");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => new { x.ProductId, x.EditionId });
                    table.ForeignKey(
                        name: "FK_ProductVariant_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariant_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Ar garantiju");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Ar garantijas plus");

            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Bez garantijas" });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 2, 1, 26.000m, 25000.00m },
                    { 3, 1, 0m, 25300.00m },
                    { 2, 2, 35000.00m, 32500.00m },
                    { 2, 3, 0m, 50000.00m },
                    { 2, 7, 0m, 72300.00m },
                    { 3, 7, 72500.00m, 72450.00m },
                    { 2, 8, 53000.00m, 51000.00m },
                    { 3, 9, 0m, 51300.00m }
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 4, 1, 25000.00m, 24500.00m },
                    { 4, 4, 70000.00m, 69000.00m },
                    { 4, 5, 55300.00m, 53000.00m },
                    { 4, 6, 402000.00m, 400000.00m },
                    { 4, 7, 73000.00m, 72000.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_EditionId",
                table: "ProductVariant",
                column: "EditionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "EditionProduct",
                columns: table => new
                {
                    EditionsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditionProduct", x => new { x.EditionsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_EditionProduct_Editions_EditionsId",
                        column: x => x.EditionsId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditionProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EditionProduct",
                columns: new[] { "EditionsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 3, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ar garantiju");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Ar garantijas plus");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Bez garantijas");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 23.750m, 25.000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 32.000m, 35.000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 49.750m, 50.000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 69.500m, 70.000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 53.000m, 55.000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 400.000m, 402.000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 72.500m, 73.000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 51.000m, 53.000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 44.750m, 45.000m });

            migrationBuilder.CreateIndex(
                name: "IX_EditionProduct_ProductsId",
                table: "EditionProduct",
                column: "ProductsId");
        }
    }
}
