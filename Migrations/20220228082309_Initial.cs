using Microsoft.EntityFrameworkCore.Migrations;

namespace dnd.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "Grade", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "email@test.com", "Nicholas", "A", "Lanes", "pass" },
                    { 2, "jfranc@gmail.com", "James", "B", "Franco", "francooo" },
                    { 3, "itsamemike@aol.com", "Michael", "D", "Scarn", "dementors" },
                    { 4, "dangitbobby@stricklandpropane.org", "Hank", "A", "Hill", "charcoal" },
                    { 5, "crowley1@gmail.com", "Sebastian", "C+", "Crowley", "crowdown" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
