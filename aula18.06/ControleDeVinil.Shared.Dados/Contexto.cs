using ControleDeVinil.Shared.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ControleDeVinil.Shared.Dados
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions options) : base(options) { }

        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }
        public DbSet<Genero> Generos{ get; set; }
    }
}
