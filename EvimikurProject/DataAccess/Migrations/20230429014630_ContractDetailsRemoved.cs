using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ContractDetailsRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierContractDetails");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "SupplierContracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "SupplierContracts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "SupplierContracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingCost",
                table: "SupplierContracts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierContracts_ProductId",
                table: "SupplierContracts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierContracts_Products_ProductId",
                table: "SupplierContracts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierContracts_Products_ProductId",
                table: "SupplierContracts");

            migrationBuilder.DropIndex(
                name: "IX_SupplierContracts_ProductId",
                table: "SupplierContracts");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "SupplierContracts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SupplierContracts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "SupplierContracts");

            migrationBuilder.DropColumn(
                name: "ShippingCost",
                table: "SupplierContracts");

            migrationBuilder.CreateTable(
                name: "SupplierContractDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierContractId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ShippingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    Tax = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierContractDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierContractDetails_SupplierContracts_SupplierContractId",
                        column: x => x.SupplierContractId,
                        principalTable: "SupplierContracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierContractDetails_SupplierContractId",
                table: "SupplierContractDetails",
                column: "SupplierContractId");
        }
    }
}
