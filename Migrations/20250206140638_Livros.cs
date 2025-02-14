using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiroMVC.Migrations
{
    /// <inheritdoc />
    public partial class Livros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    editora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qtdPaginas = table.Column<int>(type: "int", nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    sinopse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fotoCapa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
