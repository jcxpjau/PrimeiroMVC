using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroMVC.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "Cpf")]
        public string Cpf {  get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha {  get; set; } = string.Empty;

        [Column("Tipo")]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } = string.Empty;

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de Nascimento")]
        public string DataNascimento { get; set; } = string.Empty;

    }
}
