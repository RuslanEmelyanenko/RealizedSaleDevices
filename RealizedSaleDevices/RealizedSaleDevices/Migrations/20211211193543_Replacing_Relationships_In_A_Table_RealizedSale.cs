using Microsoft.EntityFrameworkCore.Migrations;

namespace RealizedSaleDevices.Migrations
{
    public partial class Replacing_Relationships_In_A_Table_RealizedSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_RealizedSales_RealizedSaleId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_RealizedSaleId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "RealizedSaleId",
                table: "Devices");

            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "RealizedSales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RealizedSales_DeviceId",
                table: "RealizedSales",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RealizedSales_Devices_DeviceId",
                table: "RealizedSales",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RealizedSales_Devices_DeviceId",
                table: "RealizedSales");

            migrationBuilder.DropIndex(
                name: "IX_RealizedSales_DeviceId",
                table: "RealizedSales");

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "RealizedSales");

            migrationBuilder.AddColumn<int>(
                name: "RealizedSaleId",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_RealizedSaleId",
                table: "Devices",
                column: "RealizedSaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_RealizedSales_RealizedSaleId",
                table: "Devices",
                column: "RealizedSaleId",
                principalTable: "RealizedSales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
