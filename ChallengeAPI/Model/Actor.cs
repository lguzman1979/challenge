using System.ComponentModel.DataAnnotations;

namespace ChallengeAPI.Model
{
    public class Actor
    {
        [Key]
        public int idActor { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
    }
}
