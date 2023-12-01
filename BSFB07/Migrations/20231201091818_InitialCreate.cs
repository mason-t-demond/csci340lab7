using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSFB07.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    primaryOffPos = table.Column<int>(type: "INTEGER", nullable: false),
                    primaryDefPos = table.Column<int>(type: "INTEGER", nullable: false),
                    primarySpePos = table.Column<int>(type: "INTEGER", nullable: false),
                    running = table.Column<int>(type: "INTEGER", nullable: false),
                    passing = table.Column<int>(type: "INTEGER", nullable: false),
                    catching = table.Column<int>(type: "INTEGER", nullable: false),
                    kicking = table.Column<int>(type: "INTEGER", nullable: false),
                    blocking = table.Column<int>(type: "INTEGER", nullable: false),
                    ovr = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
