using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swd.PlayCollector.Model.Migrations
{
    /// <inheritdoc />
    public partial class CollectionItemConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectionItems",
                table: "CollectionItems");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "CollectionItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Number of collection item",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CollectionItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Name of collection item",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CollectionItems",
                type: "decimal(8,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "Price of collection item");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectionItems",
                table: "CollectionItems",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectionItems",
                table: "CollectionItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CollectionItems");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "CollectionItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Number of collection item");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CollectionItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Name of collection item");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectionItems",
                table: "CollectionItems",
                column: "Id");
        }
    }
}
