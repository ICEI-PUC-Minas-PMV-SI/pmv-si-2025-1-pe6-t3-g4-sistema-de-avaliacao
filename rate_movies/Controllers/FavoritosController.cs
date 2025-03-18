using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rate_movies.Models;
using rate_movies.Services;

namespace rate_movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritosController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly TmdbService _tmdbService;

        public FavoritosController(AppDbContext context, TmdbService tmdbService)
        {
            _context = context;
            _tmdbService = tmdbService;
        }

        // POST: api/Favoritos
        [HttpPost]
        public async Task<ActionResult> AddFavorito(int idUsuario, int idFilme)
        {
            // Verifica se o filme já existe no banco
            var filme = await _context.Filmes.FindAsync(idFilme);
            if (filme == null)
            {
                // Se não existe, busca na API
                filme = await _tmdbService.ObterFilmePorId(idFilme);
                if (filme == null)
                {
                    return NotFound("Filme não encontrado.");
                }

                // Salva o filme no banco
                _context.Filmes.Add(filme);
                await _context.SaveChangesAsync();
            }

            // Verifica se já foi favoritado
            var favoritoExistente = await _context.Favoritos
                .FirstOrDefaultAsync(f => f.IdUsuario == idUsuario && f.IdFilme == idFilme);

            if (favoritoExistente != null)
            {
                return BadRequest("O filme já foi favoritado.");
            }

            // Adiciona aos favoritos
            var favorito = new Favorito { IdUsuario = idUsuario, IdFilme = idFilme };
            _context.Favoritos.Add(favorito);
            await _context.SaveChangesAsync();

            return Ok("Filme favoritado com sucesso!");
        }
    }
}

