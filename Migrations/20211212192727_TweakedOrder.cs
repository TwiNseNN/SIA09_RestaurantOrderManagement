using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantManagementOrder.Migrations
{
    public partial class TweakedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Cook_CookId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CookId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CookId",
                table: "Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CookId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_CookId",
                table: "Order",
                column: "CookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Cook_CookId",
                table: "Order",
                column: "CookId",
                principalTable: "Cook",
                principalColumn: "CookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
