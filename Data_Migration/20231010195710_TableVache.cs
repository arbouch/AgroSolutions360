using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgroSolutions360.Data_Migration
{
    /// <inheritdoc />
    public partial class TableVache : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaches",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_animal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_de_naissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Num_mere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_pere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race_mere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race_pere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom_animal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexe_animal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaches", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaches");
        }
    }
}
