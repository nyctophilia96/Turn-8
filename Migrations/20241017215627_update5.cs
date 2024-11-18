using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turn8.Migrations
{
    /// <inheritdoc />
    public partial class update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CircuitLength",
                table: "Blogs",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "FirstGrandPrix",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LapRecord",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfLaps",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "RaceDistance",
                table: "Blogs",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CircuitLength",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "FirstGrandPrix",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "LapRecord",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "NumberOfLaps",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "RaceDistance",
                table: "Blogs");
        }
    }
}
