using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifestyleSurveyApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Survey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pizza = table.Column<bool>(type: "bit", nullable: false),
                    Pasta = table.Column<bool>(type: "bit", nullable: false),
                    PapAndWors = table.Column<bool>(type: "bit", nullable: false),
                    Other = table.Column<bool>(type: "bit", nullable: false),
                    EatOut = table.Column<int>(type: "int", nullable: false),
                    WatchMovies = table.Column<int>(type: "int", nullable: false),
                    WatchTV = table.Column<int>(type: "int", nullable: false),
                    ListenToRadio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Survey");
        }
    }
}
