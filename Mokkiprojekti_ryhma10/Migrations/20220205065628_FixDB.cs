using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mokkiprojekti_ryhma10.Migrations
{
    public partial class FixDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cottages_Posts_PostalCodeNavigationPostalCode",
                table: "Cottages");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Posts_PostalCodeNavigationPostalCode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Cottages");

            migrationBuilder.RenameColumn(
                name: "PostalCodeNavigationPostalCode",
                table: "Customers",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_PostalCodeNavigationPostalCode",
                table: "Customers",
                newName: "IX_Customers_PostId");

            migrationBuilder.RenameColumn(
                name: "PostalCodeNavigationPostalCode",
                table: "Cottages",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Cottages_PostalCodeNavigationPostalCode",
                table: "Cottages",
                newName: "IX_Cottages_PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cottages_Posts_PostId",
                table: "Cottages",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostalCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Posts_PostId",
                table: "Customers",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostalCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cottages_Posts_PostId",
                table: "Cottages");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Posts_PostId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Customers",
                newName: "PostalCodeNavigationPostalCode");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_PostId",
                table: "Customers",
                newName: "IX_Customers_PostalCodeNavigationPostalCode");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Cottages",
                newName: "PostalCodeNavigationPostalCode");

            migrationBuilder.RenameIndex(
                name: "IX_Cottages_PostId",
                table: "Cottages",
                newName: "IX_Cottages_PostalCodeNavigationPostalCode");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Cottages",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Cottages_Posts_PostalCodeNavigationPostalCode",
                table: "Cottages",
                column: "PostalCodeNavigationPostalCode",
                principalTable: "Posts",
                principalColumn: "PostalCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Posts_PostalCodeNavigationPostalCode",
                table: "Customers",
                column: "PostalCodeNavigationPostalCode",
                principalTable: "Posts",
                principalColumn: "PostalCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
