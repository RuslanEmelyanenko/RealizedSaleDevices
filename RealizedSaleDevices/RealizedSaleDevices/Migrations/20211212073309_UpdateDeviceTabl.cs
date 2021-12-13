using Microsoft.EntityFrameworkCore.Migrations;

namespace RealizedSaleDevices.Migrations
{
    public partial class UpdateDeviceTabl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Memory_MemorySizeId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "MemoryId",
                table: "Devices");

            migrationBuilder.AlterColumn<int>(
                name: "MemorySizeId",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Memory_MemorySizeId",
                table: "Devices",
                column: "MemorySizeId",
                principalTable: "Memory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Memory_MemorySizeId",
                table: "Devices");

            migrationBuilder.AlterColumn<int>(
                name: "MemorySizeId",
                table: "Devices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MemoryId",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Memory_MemorySizeId",
                table: "Devices",
                column: "MemorySizeId",
                principalTable: "Memory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
