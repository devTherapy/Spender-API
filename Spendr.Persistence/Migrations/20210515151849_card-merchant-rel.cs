using Microsoft.EntityFrameworkCore.Migrations;

namespace Spendr.Persistence.Migrations
{
    public partial class cardmerchantrel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MerchantId",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_MerchantId",
                table: "Cards",
                column: "MerchantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Merchants_MerchantId",
                table: "Cards",
                column: "MerchantId",
                principalTable: "Merchants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Merchants_MerchantId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_MerchantId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "MerchantId",
                table: "Cards");
        }
    }
}
