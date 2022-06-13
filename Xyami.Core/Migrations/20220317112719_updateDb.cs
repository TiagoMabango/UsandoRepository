using Microsoft.EntityFrameworkCore.Migrations;

namespace Xyami.Core.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Families_FamilyFamileId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FamilyFamileId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FamilyFamileId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "FamileId",
                table: "Products",
                newName: "FamilyId");

            migrationBuilder.RenameColumn(
                name: "FamileId",
                table: "Families",
                newName: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FamilyId",
                table: "Products",
                column: "FamilyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Families_FamilyId",
                table: "Products",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "FamilyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Families_FamilyId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FamilyId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "FamilyId",
                table: "Products",
                newName: "FamileId");

            migrationBuilder.RenameColumn(
                name: "FamilyId",
                table: "Families",
                newName: "FamileId");

            migrationBuilder.AddColumn<long>(
                name: "FamilyFamileId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FamilyFamileId",
                table: "Products",
                column: "FamilyFamileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Families_FamilyFamileId",
                table: "Products",
                column: "FamilyFamileId",
                principalTable: "Families",
                principalColumn: "FamileId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
