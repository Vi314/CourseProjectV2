using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class entityFixup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierContractId",
                table: "SupplierContractDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierContractDetails_SupplierContractId",
                table: "SupplierContractDetails",
                column: "SupplierContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierContractDetails_SupplierContracts_SupplierContractId",
                table: "SupplierContractDetails",
                column: "SupplierContractId",
                principalTable: "SupplierContracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierContractDetails_SupplierContracts_SupplierContractId",
                table: "SupplierContractDetails");

            migrationBuilder.DropIndex(
                name: "IX_SupplierContractDetails_SupplierContractId",
                table: "SupplierContractDetails");

            migrationBuilder.DropColumn(
                name: "SupplierContractId",
                table: "SupplierContractDetails");
        }
    }
}
