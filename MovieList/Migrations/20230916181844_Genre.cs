using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieList.Migrations
{
    /// <inheritdoc />
    public partial class Genre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "genreId",
                table: "Movies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    genreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.genreId);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "genreId", "name" },
                values: new object[,]
                {
                    { "A", "Action" },
                    { "C", "Comedy" },
                    { "D", "Drama" },
                    { "H", "Horror" },
                    { "M", "Musical" },
                    { "R", "RomCom" },
                    { "S", "SciFi" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 1,
                column: "genreId",
                value: "D");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 2,
                column: "genreId",
                value: "A");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 3,
                column: "genreId",
                value: "R");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_genreId",
                table: "Movies",
                column: "genreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_genreId",
                table: "Movies",
                column: "genreId",
                principalTable: "Genres",
                principalColumn: "genreId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_genreId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Movies_genreId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "genreId",
                table: "Movies");
        }
    }
}
