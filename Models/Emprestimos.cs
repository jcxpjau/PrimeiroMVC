using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroMVC.Models
{
    [Table("Emprestimos")]
    public class Emprestimos
    {
        [Column("Id")]
        [Display( Name = "Cód. Empréstimo")]
        public int Id { get; set; }

        [ForeignKey("UsuarioId")]
        [Display( Name = "Usuario" )]
        public int UsuariosId { get; set; }
        public Usuarios? Usuarios { get; set; }

        [ForeignKey("LivroId")]
        [Display( Name = "Livro" )]
        public int LivrosId { get; set; }
        public Livros? Livros { get; set; }

        [Column("DataEmprestimo")]
        [Display( Name = "Data do Empréstimo")]
        public string DataEmprestimo { get; set; } = string.Empty;

        [Column("DataDevolucao")]
        [Display( Name = "Data de Devolução")]
        public string DataDevolucao {  get; set; } = string.Empty;
    }
}
