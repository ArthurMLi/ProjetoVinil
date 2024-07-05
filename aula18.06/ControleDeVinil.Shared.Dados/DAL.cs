using ControleDeVinil.Shared.Modelos;

namespace ControleDeVinil.Shared.Dados
{
    public class DAL
    {
        private readonly Contexto context;

        public List<Artista> ListarArtista()
        {
            var lista = new List<Artista>
            {
                new Artista {Id = 1, Nome = "Luiz Felipe", Bio = "Maior cantor do cotemig", FotoPerfil = ""}
            };
            return lista;

        }
        public List<Musica> ListarMusica()
        {
            var lista = new List<Musica>
            {
                new Musica {Id = 1, Titulo = "Tche Thce rere Tche Tche", Compositor = "Luiz Felipe", Duracao = 40}
            };
            return lista;

        }
    }
}
