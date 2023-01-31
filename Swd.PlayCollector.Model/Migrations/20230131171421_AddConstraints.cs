using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swd.PlayCollector.Model.Migrations
{
    /// <inheritdoc />
    public partial class AddConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollectionItem_Location_LocationId",
                table: "CollectionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CollectionItem_Theme_ThemeId",
                table: "CollectionItem");

            migrationBuilder.AlterColumn<int>(
                name: "ThemeId",
                table: "CollectionItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseYear",
                table: "CollectionItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "CollectionItem",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                comment: "Number of collection item",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldComment: "Number of collection item");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "CollectionItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionItem_Location_LocationId",
                table: "CollectionItem",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionItem_Theme_ThemeId",
                table: "CollectionItem",
                column: "ThemeId",
                principalTable: "Theme",
                principalColumn: "Id");
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

            migrationBuilder.AlterColumn<int>(
                name: "ThemeId",
                table: "CollectionItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseYear",
                table: "CollectionItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "CollectionItem",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                comment: "Number of collection item",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true,
                oldComment: "Number of collection item");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "CollectionItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
