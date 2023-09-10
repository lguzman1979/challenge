using System.ComponentModel.DataAnnotations;

namespace ChallengeAPI.Model
{
    public class Productora
    {

        [Key]
        public int idProductora { get; set; }
        [Required]
        public string Nombre { get; set; }
        public DateTime FechaFundacion { get; set; }
    }
}
