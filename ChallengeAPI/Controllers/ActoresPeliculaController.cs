using ChallengeAPI.Data;
using ChallengeAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAPI.Controllers
{
    [ApiController]
    [Route("ActorPelicula")]
    public class ActoresPeliculaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ActoresPeliculaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GET")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.actor_has_pelicula.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetByIdActor(int id)
        {
            try
            {
                return Ok(_context.actor_has_pelicula.Where(x => x.Actor_idActor == id).FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("POST")]
        public IActionResult POST(actor_has_pelicula actor_pelicula)
        {
            try
            {
                _context.actor_has_pelicula.Add(actor_pelicula);
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
