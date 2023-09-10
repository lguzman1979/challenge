using System.ComponentModel.DataAnnotations;

namespace ChallengeAPI.Model
{
    public class Genero
    {
        [Key]
        public int idGenero { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
