using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantManagementOrder.Migrations
{
    public partial class ChangedOrderItemRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "OrderItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
