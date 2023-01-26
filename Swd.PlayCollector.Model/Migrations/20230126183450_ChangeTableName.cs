using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swd.PlayCollector.Model.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollectionItems_Location_LocationId",
                table: "CollectionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CollectionItems_Theme_ThemeId",
                table: "CollectionItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectionItems",
                table: "CollectionItems");

            migrationBuilder.RenameTable(
                name: "CollectionItems",
                newName: "CollectionItem");

            migrationBuilder.RenameIndex(
                name: "IX_CollectionItems_ThemeId",
                table: "CollectionItem",
                newName: "IX_CollectionItem_ThemeId");

            migrationBuilder.RenameIndex(
                name: "IX_CollectionItems_LocationId",
                table: "CollectionItem",
                newName: "IX_CollectionItem_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectionItem",
                table: "CollectionItem",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionItem_Location_LocationId",
                table: "CollectionItem",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionItem_Theme_ThemeId",
                table: "CollectionItem",
                column: "ThemeId",
                principalTable: "Theme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollectionItem_Location_LocationId",
                table: "CollectionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CollectionItem_Theme_ThemeId",
                table: "CollectionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectionItem",
                table: "CollectionItem");

            migrationBuilder.RenameTable(
                name: "CollectionItem",
                newName: "CollectionItems");

            migrationBuilder.RenameIndex(
                name: "IX_CollectionItem_ThemeId",
                table: "CollectionItems",
                newName: "IX_CollectionItems_ThemeId");

            migrationBuilder.RenameIndex(
                name: "IX_CollectionItem_LocationId",
                table: "CollectionItems",
                newName: "IX_CollectionItems_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectionItems",
                table: "CollectionItems",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionItems_Location_LocationId",
                table: "CollectionItems",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionItems_Theme_ThemeId",
                table: "CollectionItems",
                column: "ThemeId",
                principalTable: "Theme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
