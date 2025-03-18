using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rate_movies.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string IdNome { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        // Relacionamento N:N com Filme (tabela de junção Favorito)
        public ICollection<Favorito> Favoritos { get; set; } = new List<Favorito>();

        // Relacionamento N:N com Filme (tabela de junção Comentario)
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}
