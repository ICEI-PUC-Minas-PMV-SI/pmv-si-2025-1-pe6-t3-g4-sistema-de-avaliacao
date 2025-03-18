using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace rate_movies.Models
{
    [Table("Comentarios")]
    public class Comentario
    {
        [Key]
        public int IdComentario { get; set; }

        public int IdUsuario { get; set; }
        public int IdFilme { get; set; }

        [Required]
        public DateTime DataComentario { get; set; } = DateTime.UtcNow;

        [Required]
        [MaxLength(1000)]
        public string Conteudo { get; set; }

        // Relacionamento com Usuario e Filme
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        [ForeignKey("IdFilme")]
        public Filme Filme { get; set; }
    }
}
