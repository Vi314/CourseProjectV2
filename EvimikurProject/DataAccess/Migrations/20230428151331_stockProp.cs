using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class stockProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MinimumAmount",
                table: "DealerStocks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "DealerStocks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DealerStocks_SupplierId",
                table: "DealerStocks",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_DealerStocks_Suppliers_SupplierId",
                table: "DealerStocks",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DealerStocks_Suppliers_SupplierId",
                table: "DealerStocks");

            migrationBuilder.DropIndex(
                name: "IX_DealerStocks_SupplierId",
                table: "DealerStocks");

            migrationBuilder.DropColumn(
                name: "MinimumAmount",
                table: "DealerStocks");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "DealerStocks");
        }
    }
}
