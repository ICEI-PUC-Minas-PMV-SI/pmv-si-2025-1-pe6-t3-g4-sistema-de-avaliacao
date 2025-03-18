using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rate_movies.Models;

namespace rate_movies.Controllers
{


    [Route("api/[controller]")]
    [ApiController]


    public class UsuariosController: ControllerBase
    {
        private readonly AppDbContext _context;
        

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }


        //GET: api/Usuarios
        [HttpGet]

        public async Task<ActionResult> GetAll()
        {
            try
            {
                var usuarios = await _context.Usuarios.ToListAsync();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Usuario
        [HttpPost]
        public async Task<ActionResult> AddUsuario(Usuario usuario)
        {
            // Verifica se já existe um usuário com o mesmo e-mail e o mesmo idNome
            if (_context.Usuarios.Any(u => u.Email == usuario.Email && u.IdNome == usuario.IdNome))
            {
                return BadRequest("Já existe um usuário com esse e-mail e idNome cadastrados.");
            }

            try
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(AddUsuario), new { id = usuario.IdUsuario }, usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
