using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VillageDrill.Migrations
{
    public partial class UpdateNavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "OrderItemID",
                table: "OrderItem",
                newName: "OrderItemId");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderID",
                table: "PurchaseOrder",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "OrderItemId",
                table: "OrderItem",
                nullable: true,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemID",
                table: "OrderItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderItemId",
                table: "OrderItem",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_PurchaseOrder_OrderItemID",
                table: "OrderItem",
                column: "OrderItemID",
                principalTable: "PurchaseOrder",
                principalColumn: "PurchaseOrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Item_OrderItemId",
                table: "OrderItem",
                column: "OrderItemId",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_Vendor_PurchaseOrderID",
                table: "PurchaseOrder",
                column: "PurchaseOrderID",
                principalTable: "Vendor",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_PurchaseOrder_OrderItemID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Item_OrderItemId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_Vendor_PurchaseOrderID",
                table: "PurchaseOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderItemId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "OrderItemID",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "OrderItem",
                newName: "OrderItemID");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderID",
                table: "PurchaseOrder",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "OrderItemID",
                table: "OrderItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "OrderItemID");
        }
    }
}
