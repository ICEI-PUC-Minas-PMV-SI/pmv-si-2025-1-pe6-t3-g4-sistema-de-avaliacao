using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rate_movies.Models;
using rate_movies.Services;
using rate_movies.Dtos;

namespace rate_movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentariosController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly TmdbService _tmdbService;

        public ComentariosController(AppDbContext context, TmdbService tmdbService)
        {
            _context = context;
            _tmdbService = tmdbService;
        }

        // POST: api/Comentarios
        [HttpPost]
        public async Task<ActionResult> AddComentario([FromBody] ComentarioDto comentarioDto)
        {
            // Verifica se o filme já existe no banco
            var filme = await _context.Filmes.FindAsync(comentarioDto.IdFilme);
            if (filme == null)
            {
                // Busca na API e adiciona no banco
                filme = await _tmdbService.ObterFilmePorId(comentarioDto.IdFilme);
                if (filme == null)
                {
                    return NotFound("Filme não encontrado.");
                }

                _context.Filmes.Add(filme);
                await _context.SaveChangesAsync();
            }

            // Adiciona o comentário
            var comentario = new Comentario
            {
                IdUsuario = comentarioDto.IdUsuario,
                IdFilme = comentarioDto.IdFilme,
                Conteudo = comentarioDto.Conteudo,
                DataComentario = DateTime.UtcNow // Define a data atual
            };

            _context.Comentarios.Add(comentario);
            await _context.SaveChangesAsync();

            return Ok("Comentário adicionado!");
        }
    }
}
