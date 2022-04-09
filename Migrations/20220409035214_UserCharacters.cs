using Microsoft.EntityFrameworkCore.Migrations;

namespace dnd.Migrations
{
    public partial class UserCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

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
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterRace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterLevel = table.Column<int>(type: "int", nullable: false),
                    CharacterBackground = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alignment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperiencePoints = table.Column<int>(type: "int", nullable: false),
                    StrengthVal = table.Column<int>(type: "int", nullable: false),
                    DexterityVal = table.Column<int>(type: "int", nullable: false),
                    ConstitutionVal = table.Column<int>(type: "int", nullable: false),
                    IntelligenceVal = table.Column<int>(type: "int", nullable: false),
                    WisdomVal = table.Column<int>(type: "int", nullable: false),
                    CharismaVal = table.Column<int>(type: "int", nullable: false),
                    InspirationVal = table.Column<int>(type: "int", nullable: false),
                    ProficiencyBonusVal = table.Column<int>(type: "int", nullable: false),
                    SavingThrows = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArmorClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitiativeVal = table.Column<int>(type: "int", nullable: false),
                    SpeedVal = table.Column<int>(type: "int", nullable: false),
                    CurrentHealth = table.Column<int>(type: "int", nullable: false),
                    TemporaryHealth = table.Column<int>(type: "int", nullable: false),
                    HitDice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeathSaveSuccess = table.Column<int>(type: "int", nullable: false),
                    DeathSaveFailure = table.Column<int>(type: "int", nullable: false),
                    PersonalityTraits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ideals = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bonds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flaws = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Traits = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
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
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbilityModifier = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Strength" },
                    { 2, "Dexterity" },
                    { 3, "Constitution" },
                    { 4, "Intelligence" },
                    { 5, "Wisdom" },
                    { 6, "Charisma" }
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
                table: "Characters",
                columns: new[] { "CharacterId", "Alignment", "ArmorClass", "Bonds", "CharacterBackground", "CharacterClass", "CharacterLevel", "CharacterName", "CharacterRace", "CharismaVal", "ConstitutionVal", "CurrentHealth", "DeathSaveFailure", "DeathSaveSuccess", "DexterityVal", "ExperiencePoints", "Flaws", "HitDice", "Ideals", "InitiativeVal", "InspirationVal", "IntelligenceVal", "PersonalityTraits", "ProficiencyBonusVal", "SavingThrows", "SpeedVal", "StrengthVal", "TemporaryHealth", "Traits", "WisdomVal" },
                values: new object[] { -1, "Lawful Good", "Light Armor", "Woodland Creatures", "Woodland archer", "Rogue", 1, "Faendal", "Elf", 3, 6, 10, 1, 0, 7, 1, "Poor Eyesight.", "D8", "The Greater Good Supasses all Individual Needs.", 2, 4, 7, "Quiet, Mild-Mannered, Investigatory", 1, "Intelligence, Dexterity", 3, 5, 8, "Speaks Elven dialects as well as Human dialects.", 8 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Barbarian" },
                    { 2, "Bard" },
                    { 3, "Cleric" },
                    { 4, "Druid" },
                    { 5, "Fighter" },
                    { 6, "Monk" },
                    { 7, "Paladin" },
                    { 8, "Ranger" },
                    { 9, "Rogue" },
                    { 10, "Sorcerer" },
                    { 11, "Warlock" },
                    { 12, "Wizard" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Tiefling" },
                    { 8, "Human" },
                    { 7, "Half-Orc" },
                    { 6, "Halfling" },
                    { 1, "Dragonborn" },
                    { 4, "Gnome" },
                    { 3, "Elf" },
                    { 2, "Dwarf" },
                    { 5, "Half-Elf" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AbilityModifier", "Name" },
                values: new object[,]
                {
                    { 16, "Dexterity", "Sleight of Hand" },
                    { 15, "Intelligence", "Religion" },
                    { 14, "Charisma", "Persuasion" },
                    { 13, "Charisma", "Performance" },
                    { 12, "Wisdom", "Perception" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AbilityModifier", "Name" },
                values: new object[,]
                {
                    { 11, "Intelligence", "Nature" },
                    { 10, "Wisdom", "Medicine" },
                    { 9, "Intelligence", "Investigation" },
                    { 8, "Charisma", "Intimidation" },
                    { 6, "Intelligence", "History" },
                    { 5, "Charisma", "Deception" },
                    { 4, "Strength", "Athletics" },
                    { 3, "Intelligence", "Arcana" },
                    { 2, "Wisdom", "Animal Handling" },
                    { 1, "Dexterity", "Acrobatics" },
                    { 17, "Dexterity", "Stealth" },
                    { 7, "Wisdom", "Insight" },
                    { 18, "Wisdom", "Survival" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsAdmin", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 2, true, "Admin Sawyer", "password", "admin" },
                    { 1, false, "John Smith", "password", "user" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Alignments");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
