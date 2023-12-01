using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSFB07.Migrations
{
    /// <inheritdoc />
    public partial class PlayerPosFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    primaryOffPos = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    primaryDefPos = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    primarySpePos = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    Running = table.Column<int>(type: "INTEGER", nullable: false),
                    Passing = table.Column<int>(type: "INTEGER", nullable: false),
                    Catching = table.Column<int>(type: "INTEGER", nullable: false),
                    Kicking = table.Column<int>(type: "INTEGER", nullable: false),
                    Blocking = table.Column<int>(type: "INTEGER", nullable: false),
                    Ovr = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
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
