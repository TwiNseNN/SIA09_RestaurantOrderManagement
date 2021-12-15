using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantManagementOrder.Migrations
{
    public partial class TweakedOrder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReverted",
                table: "OrderItem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReverted",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "OrderItem");
        }
    }
}
