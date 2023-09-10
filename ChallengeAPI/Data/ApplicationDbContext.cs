using ChallengeAPI.Model;
using Microsoft.EntityFrameworkCore;



namespace ChallengeAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Pelicula> Pelicula { get; set; }
        public DbSet<Actor> Actor{ get; set; }
        public DbSet<Imagen> Imagen{ get; set; }
        public DbSet<Productora> Productora { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<actor_has_pelicula> actor_has_pelicula { get; set; }

    }
}
