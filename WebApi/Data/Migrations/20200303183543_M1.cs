using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "speakers",
                columns: table => new
                {
                    speakerId = table.Column<string>(nullable: false),
                    firstName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    mobileNumber = table.Column<string>(nullable: false),
                    areaOfSpecialization = table.Column<string>(nullable: false),
                    cityOfResidence = table.Column<string>(nullable: false),
                    provinceOfResidence = table.Column<string>(nullable: false),
                    employer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speakers", x => x.speakerId);
                });

            migrationBuilder.InsertData(
                table: "speakers",
                columns: new[] { "speakerId", "areaOfSpecialization", "cityOfResidence", "email", "employer", "firstName", "lastName", "mobileNumber", "provinceOfResidence" },
                values: new object[] { "391e1ff8-5da4-4d65-8611-a56f2daa8ec6", "Cloud Architect", "Chillwack", "jim@potter.ca", "BC Hydro", "Jim", "Potter", "604-123-4567", "BC" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "speakers");
        }
    }
}
