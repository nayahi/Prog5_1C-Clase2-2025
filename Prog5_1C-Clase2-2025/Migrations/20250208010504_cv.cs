using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prog5_1C_Clase2_2025.Migrations
{
    /// <inheritdoc />
    public partial class cv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentroVacunacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroVacunacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enfermedades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enfermedad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermedades", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CentroVacunacion");

            migrationBuilder.DropTable(
                name: "Enfermedades");
        }
    }
}
