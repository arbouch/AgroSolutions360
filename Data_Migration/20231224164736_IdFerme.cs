using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgroSolutions360.Data_Migration
{
    /// <inheritdoc />
    public partial class IdFerme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdFerme",
                table: "Vaches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdFerme",
                table: "Vaches");
        }
    }
}
