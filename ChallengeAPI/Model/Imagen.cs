using System.ComponentModel.DataAnnotations;

namespace ChallengeAPI.Model
{
    public class Imagen
    {
        [Key]
        public int idImagen { get; set; }
        [Required]
        public string Ruta { get; set; }
        public int Peso { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
    }
}
