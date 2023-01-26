using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swd.PlayCollector.Model.Migrations
{
    /// <inheritdoc />
    public partial class AddMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeOfDocument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", unicode: false, nullable: false, comment: "Name of document type")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfDocument", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "Name of media item"),
                    Uri = table.Column<string>(type: "nvarchar(255)", unicode: false, nullable: false, comment: "Uri of media item"),
                    TypeOfDocumentId = table.Column<int>(type: "int", nullable: false),
                    CollectionItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Media_CollectionItem_CollectionItemId",
                        column: x => x.CollectionItemId,
                        principalTable: "CollectionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Media_TypeOfDocument_TypeOfDocumentId",
                        column: x => x.TypeOfDocumentId,
                        principalTable: "TypeOfDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_Media_Name",
                table: "Media",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Media_CollectionItemId",
                table: "Media",
                column: "CollectionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_TypeOfDocumentId",
                table: "Media",
                column: "TypeOfDocumentId");

            migrationBuilder.CreateIndex(
                name: "idx_TypeofDocument_Name",
                table: "TypeOfDocument",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "TypeOfDocument");
        }
    }
}
