using Microsoft.EntityFrameworkCore;

namespace PrimeiroMVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options ) : base (options) { 

        }

        //** ESSA É A HORA QUE VC BRILHA **//
        public DbSet<Livros> Livros { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Emprestimos> Emprestimos { get; set; }

        //** ESSA É A HORA DE PARAR **//
    }
}
