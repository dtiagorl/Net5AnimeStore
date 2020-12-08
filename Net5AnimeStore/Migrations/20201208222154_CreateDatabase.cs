using Microsoft.EntityFrameworkCore.Migrations;

namespace Net5AnimeStore.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_console",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShortDescription = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    LongDescription = table.Column<string>(type: "TEXT", maxLength: 700, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_console", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_figure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShortDescription = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    LongDescription = table.Column<string>(type: "TEXT", maxLength: 700, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_figure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_game",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShortDescription = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    LongDescription = table.Column<string>(type: "TEXT", maxLength: 700, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_game", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_console");

            migrationBuilder.DropTable(
                name: "tbl_figure");

            migrationBuilder.DropTable(
                name: "tbl_game");
        }
    }
}
