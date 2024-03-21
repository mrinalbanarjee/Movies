using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.API.Migrations
{
    public partial class UpdateDirectorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Score",
                table: "Directors",
                type: "float",
                maxLength: 2,
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Directors");
        }
    }
}
