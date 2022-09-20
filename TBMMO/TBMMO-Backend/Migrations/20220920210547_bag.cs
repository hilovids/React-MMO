using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TBMMO_Backend.Migrations
{
    public partial class bag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bag_Inventory_InventoryId",
                table: "Bag");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Bag_BagId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bag",
                table: "Bag");

            migrationBuilder.RenameTable(
                name: "Bag",
                newName: "Bags");

            migrationBuilder.RenameIndex(
                name: "IX_Bag_InventoryId",
                table: "Bags",
                newName: "IX_Bags_InventoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bags",
                table: "Bags",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Inventory_InventoryId",
                table: "Bags",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Bags_BagId",
                table: "Items",
                column: "BagId",
                principalTable: "Bags",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Inventory_InventoryId",
                table: "Bags");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Bags_BagId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bags",
                table: "Bags");

            migrationBuilder.RenameTable(
                name: "Bags",
                newName: "Bag");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_InventoryId",
                table: "Bag",
                newName: "IX_Bag_InventoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bag",
                table: "Bag",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_Inventory_InventoryId",
                table: "Bag",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Bag_BagId",
                table: "Items",
                column: "BagId",
                principalTable: "Bag",
                principalColumn: "Id");
        }
    }
}
