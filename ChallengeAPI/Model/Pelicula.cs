using System.ComponentModel.DataAnnotations;

namespace ChallengeAPI.Model
{
    public class Pelicula
    {
        [Key]
        public int idPelicula { get; set; }

        public string Nombre { get; set; }
        public int Duracion { get; set; }

        public decimal Puntuacion { get; set; }

        public int PresupuestoUsd { get; set; }

        public int Imagen_idImagen { get; set; }

        public int Productora_idProductora { get; set; }
    }
}
