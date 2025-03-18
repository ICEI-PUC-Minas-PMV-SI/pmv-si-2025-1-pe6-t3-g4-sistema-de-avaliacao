using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rate_movies.Models;
using rate_movies.Services;


namespace rate_movies.Controllers
{
    [Route("api/[controller]")]
    //Para acessar essa rota, utilize: https://localhost:5001/api/Filmes
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly AppDbContext _context;

        //criado para acessar o banco de dados pelo _context.

        private readonly TmdbService _tmdbService;

        //injecao de dependencia
        public FilmesController(AppDbContext context, TmdbService tmdbService)
        {
            _context = context;
            _tmdbService = tmdbService;
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetById(int id)
        {
            // Verifica se o filme já está no banco
            var filme = await _context.Filmes.FindAsync(id);

            if (filme == null)
            {
                // Se não estiver no banco, busca na API do TMDB
                filme = await _tmdbService.ObterFilmePorId(id);
                if (filme == null)
                {
                    return NotFound("Filme não encontrado.");
                }

                // Salva no banco
                _context.Filmes.Add(filme);
                await _context.SaveChangesAsync();
            }

            return Ok(filme);
        }


        // GET: api/Filmes
        [HttpGet]
        //Para acessar essa rota, utilize: https://localhost:5001/api/Filmes
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var filmes = await _context.Filmes.ToListAsync();
                return Ok(filmes);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


    }
}
