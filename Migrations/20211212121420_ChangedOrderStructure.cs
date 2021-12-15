using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantManagementOrder.Migrations
{
    public partial class ChangedOrderStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Order",
                newName: "TableNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethod",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "TableNumber",
                table: "Order",
                newName: "Total");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethod",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
