using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SalesAndEmployeeVacationAndEntryAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dealers_Sales_SaleId",
                table: "Dealers");

            migrationBuilder.DropIndex(
                name: "IX_Dealers_SaleId",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Dealers");

            migrationBuilder.CreateTable(
                name: "DealerSale",
                columns: table => new
                {
                    DealerId = table.Column<int>(type: "int", nullable: false),
                    SalesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerSale", x => new { x.DealerId, x.SalesId });
                    table.ForeignKey(
                        name: "FK_DealerSale_Dealers_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DealerSale_Sales_SalesId",
                        column: x => x.SalesId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DealerSale_SalesId",
                table: "DealerSale",
                column: "SalesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DealerSale");

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "Dealers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_SaleId",
                table: "Dealers",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dealers_Sales_SaleId",
                table: "Dealers",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id");
        }
    }
}
