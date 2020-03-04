using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class locationId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LibraryBranchId",
                table: "LibraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_LibraryAssets_LibraryBranchId",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "LibraryBranchId",
                table: "LibraryAssets");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "LibraryAssets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssets_LocationId",
                table: "LibraryAssets",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets",
                column: "LocationId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_LibraryAssets_LocationId",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "LibraryAssets");

            migrationBuilder.AddColumn<int>(
                name: "LibraryBranchId",
                table: "LibraryAssets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssets_LibraryBranchId",
                table: "LibraryAssets",
                column: "LibraryBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LibraryBranchId",
                table: "LibraryAssets",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
