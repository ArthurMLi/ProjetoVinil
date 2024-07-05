using ControleDeVinil.Shared.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeVinil.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistaController : ControllerBase
    {
        private List<Artista> Artistas = new List<Artista>
        {
            new Artista{Id = 1, Nome = "Luiz Felipe", Bio = "maior cantor do cotemig", FotoPerfil=""},
            new Artista{Id = 2, Nome = "Eduardo hoffmam", Bio = "tche thce re re tche tche", FotoPerfil=""},
            new Artista{Id = 3, Nome = "Henrique brinks", Bio = "Barreiro", FotoPerfil=""}

        };
        [HttpGet]
        public IActionResult Get()
        {
            var artista = this.Artistas;
            if (artista != null)
            {
                return Ok(artista);
            }
            return NotFound();
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var artista = this.Artistas.FirstOrDefault(a => a.Id == id);
            if (artista != null)
            {
                return Ok(artista);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Post(Artista novoArtista)
        {
            novoArtista.Id = this.Artistas.Max(a => a.Id) + 1;
            this.Artistas.Append(novoArtista);
            await Task.Delay(100);
            return Created($"/{novoArtista.Id}", novoArtista);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, Artista novoArtista)
        {
            try
            {
                await Task.Delay(100);
                if (id == novoArtista.Id)
                {
                    var itemAExcluir = this.Artistas.FirstOrDefault(a => a.Id == id);
                    if (itemAExcluir != null)
                    {
                        if (itemAExcluir.Nome == novoArtista.Nome && itemAExcluir.Bio == novoArtista.Bio)
                        {
                            this.Artistas.Remove(itemAExcluir);
                            return Ok();
                        }
                    }
                }
                return Conflict();
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }
        [HttpPut("{id}")]

        public async Task<IActionResult> Atualizar(int id, Artista artistaAAlterar)
        {
            try
            {
                await Task.Delay(100);
                if (id == artistaAAlterar.Id)
                {
                    var itemAAlterar = this.Artistas.FirstOrDefault(a => a.Id == id);
                    if (itemAAlterar != null)
                    {
                        itemAAlterar.Nome = artistaAAlterar.Nome;
                        itemAAlterar.Bio = artistaAAlterar.Bio;
                        itemAAlterar.FotoPerfil = artistaAAlterar.FotoPerfil;
                        return Ok();
                    }

                }
                return Conflict();
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }
    }
}
