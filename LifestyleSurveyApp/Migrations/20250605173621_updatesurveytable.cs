using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifestyleSurveyApp.Migrations
{
    /// <inheritdoc />
    public partial class updatesurveytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Survey",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Survey");
        }
    }
}
