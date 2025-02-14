using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroMVC.Models
{
    [Table("Livros")]
    public class Livros
    {
        [Column("Id")]
        [Display(Name = "Código de Livro")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Título do Livro")]
        public string Titulo { get; set; } = string.Empty;

        [Column("isbn")]
        [Display(Name = "ISBN do Livro")]
        public string ISBN { get; set; } = string.Empty;

        [Column("autor")]
        [Display(Name = "Autor do Livro")]
        public string Autor { get; set; } = string.Empty;

        [Column("editora")]
        [Display(Name = "Editora do Livro")]
        public string Editora { get; set; } = string.Empty;

        [Column("qtdPaginas")]
        [Display(Name = "Qtde Paginas")]
        public int QtdPaginas { get; set; }

        [Column("ano")]
        [Display(Name = "Ano Publicação")]
        public int Ano { get; set; }

        [Column("sinopse")]
        [Display(Name = "Sinopse do Livro")]
        public string Sinopse { get; set; } = string.Empty;

        [Column("fotoCapa")]
        [Display(Name = "Foto da Capa")]
        public string FotoCapa { get; set; } = string.Empty;

    }
}
