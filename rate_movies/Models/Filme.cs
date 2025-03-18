using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rate_movies.Models
{

    [Table("Filmes")]
    public class Filme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Permite definir o ID manualmente
        public int IdFilme { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nome { get; set; }

        [MaxLength(20)]
        public string Genero { get; set; }

        [Range(0, 10)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Nota { get; set; }

        [MaxLength(500)]
        public string FotoUrl { get; set; } // URL da imagem do filme vinda da API externa

        // Relacionamento N:N com Usuario (tabela de junção Favorito)
        public ICollection<Favorito> UsuariosFavoritaram { get; set; } = new List<Favorito>();

        // Relacionamento N:N com Usuario (tabela de junção Comentario)
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    }
}
