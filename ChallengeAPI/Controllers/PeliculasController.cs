using ChallengeAPI.Data;
using ChallengeAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeAPI.Controllers
{
    [ApiController]
    [Route("Peliculas")]
    public class PeliculasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PeliculasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GET")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Pelicula.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_context.Pelicula.Where(x => x.idPelicula == id).FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("GetByIdActor")]
        public IActionResult GetByIdActor(int id)
        {
            try
            {

                var ids = _context.actor_has_pelicula.Where(x => x.Actor_idActor == id).Select(i => i.Pelicula_idPelicula).ToList();
                return Ok(_context.Pelicula.Where(x => ids.Contains(x.idPelicula)).ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("POST")]
        public IActionResult POST(Pelicula pelicula)
        {
            try
            {
                _context.Pelicula.Add(pelicula);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
