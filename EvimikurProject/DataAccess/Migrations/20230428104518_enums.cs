using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class enums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEligible",
                table: "Suppliers");

            migrationBuilder.AddColumn<int>(
                name: "ApprovalState",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractState",
                table: "SupplierContracts",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalState",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "ContractState",
                table: "SupplierContracts");

            migrationBuilder.AddColumn<bool>(
                name: "IsEligible",
                table: "Suppliers",
                type: "bit",
                nullable: true);
        }
    }
}
