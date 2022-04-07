using Microsoft.EntityFrameworkCore.Migrations;

namespace dnd.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterClassId = table.Column<int>(type: "int", nullable: true),
                    CharacterRaceId = table.Column<int>(type: "int", nullable: true),
                    CharacterLevel = table.Column<int>(type: "int", nullable: false),
                    CharacterBackground = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterAlignment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperiencePoints = table.Column<int>(type: "int", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Classes_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Races_CharacterRaceId",
                        column: x => x.CharacterRaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Alignments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lawful Good" },
                    { 2, "Neutral Good" },
                    { 3, "Chaotic Good" },
                    { 4, "Lawful Neutral" },
                    { 5, "True Neutral" },
                    { 6, "Chaotic Neutral" },
                    { 7, "Lawful Evil" },
                    { 8, "Neutral Evil" },
                    { 9, "Chaotic Evil" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 12, "Wizard" },
                    { 11, "Warlock" },
                    { 10, "Sorcerer" },
                    { 9, "Rogue" },
                    { 8, "Ranger" },
                    { 7, "Paladin" },
                    { 5, "Fighter" },
                    { 4, "Druid" },
                    { 3, "Cleric" },
                    { 2, "Bard" },
                    { 1, "Barbarian" },
                    { 6, "Monk" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Elf" },
                    { 1, "Dragonborn" },
                    { 2, "Dwarf" },
                    { 4, "Gnome" },
                    { 5, "Half-Elf" },
                    { 6, "Halfling" },
                    { 7, "Half-Orc" },
                    { 8, "Human" },
                    { 9, "Tiefling" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsAdmin", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 1, false, "John Smith", "password", "user" },
                    { 2, true, "Admin Sawyer", "password", "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterClassId",
                table: "Characters",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterRaceId",
                table: "Characters",
                column: "CharacterRaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alignments");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
