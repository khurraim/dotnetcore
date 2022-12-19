using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderApp.Migrations
{
    /// <inheritdoc />
    public partial class OrderChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Products_ProductID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Order_OrderID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Order_ProductID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Order",
                newName: "OrderPhone");

            migrationBuilder.AddColumn<string>(
                name: "OrderItem",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderItem",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "OrderPhone",
                table: "Order",
                newName: "ProductID");

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderID",
                table: "Products",
                column: "OrderID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Order_OrderID",
                table: "Products",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID");
        }
    }
}
