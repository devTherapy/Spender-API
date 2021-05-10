using Microsoft.EntityFrameworkCore.Migrations;

namespace Spendr.Persistence.Migrations
{
    public partial class entityrelationcorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MerchantAddresses_Merchants_MerchantId1",
                table: "MerchantAddresses");

            migrationBuilder.DropIndex(
                name: "IX_MerchantContacts_MerchantId",
                table: "MerchantContacts");

            migrationBuilder.DropIndex(
                name: "IX_MerchantAddresses_MerchantId",
                table: "MerchantAddresses");

            migrationBuilder.DropIndex(
                name: "IX_MerchantAddresses_MerchantId1",
                table: "MerchantAddresses");

            migrationBuilder.DropColumn(
                name: "MerchantId1",
                table: "MerchantAddresses");

            migrationBuilder.AddColumn<string>(
                name: "ProfileUrl",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantContacts_MerchantId",
                table: "MerchantContacts",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_MerchantAddresses_MerchantId",
                table: "MerchantAddresses",
                column: "MerchantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MerchantContacts_MerchantId",
                table: "MerchantContacts");

            migrationBuilder.DropIndex(
                name: "IX_MerchantAddresses_MerchantId",
                table: "MerchantAddresses");

            migrationBuilder.DropColumn(
                name: "ProfileUrl",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "MerchantId1",
                table: "MerchantAddresses",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantContacts_MerchantId",
                table: "MerchantContacts",
                column: "MerchantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantAddresses_MerchantId",
                table: "MerchantAddresses",
                column: "MerchantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantAddresses_MerchantId1",
                table: "MerchantAddresses",
                column: "MerchantId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MerchantAddresses_Merchants_MerchantId1",
                table: "MerchantAddresses",
                column: "MerchantId1",
                principalTable: "Merchants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
