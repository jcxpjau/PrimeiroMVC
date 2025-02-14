using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiroMVC.Migrations
{
    /// <inheritdoc />
    public partial class Emprestimos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuariosId = table.Column<int>(type: "int", nullable: false),
                    LivrosId = table.Column<int>(type: "int", nullable: false),
                    DataEmprestimo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDevolucao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Livros_LivrosId",
                        column: x => x.LivrosId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_LivrosId",
                table: "Emprestimos",
                column: "LivrosId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_UsuariosId",
                table: "Emprestimos",
                column: "UsuariosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimos");
        }
    }
}
