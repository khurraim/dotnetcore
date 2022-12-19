using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderApp.Migrations
{
    /// <inheritdoc />
    public partial class AnotherMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProductID",
                table: "Order",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Products_ProductID",
                table: "Order",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Products_ProductID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ProductID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Order");
        }
    }
}
