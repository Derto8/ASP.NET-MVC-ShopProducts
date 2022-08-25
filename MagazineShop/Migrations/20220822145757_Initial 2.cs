using Microsoft.EntityFrameworkCore.Migrations;

namespace MagazineShop.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProductItem_Products_ProductId",
                table: "ShopProductItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopProductItem",
                table: "ShopProductItem");

            migrationBuilder.RenameTable(
                name: "ShopProductItem",
                newName: "ShopCartItem");

            migrationBuilder.RenameIndex(
                name: "IX_ShopProductItem_ProductId",
                table: "ShopCartItem",
                newName: "IX_ShopCartItem_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopCartItem",
                table: "ShopCartItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItem_Products_ProductId",
                table: "ShopCartItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItem_Products_ProductId",
                table: "ShopCartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopCartItem",
                table: "ShopCartItem");

            migrationBuilder.RenameTable(
                name: "ShopCartItem",
                newName: "ShopProductItem");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCartItem_ProductId",
                table: "ShopProductItem",
                newName: "IX_ShopProductItem_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopProductItem",
                table: "ShopProductItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProductItem_Products_ProductId",
                table: "ShopProductItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
