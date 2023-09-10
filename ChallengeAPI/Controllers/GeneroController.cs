using ChallengeAPI.Data;
using ChallengeAPI.Data.DTO;
using ChallengeAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAPI.Controllers
{
    [ApiController]
    [Route("Generos")]
    public class GeneroController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GeneroController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GET")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Genero.ToList());
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
                return Ok(_context.Genero.Where(x => x.idGenero == id).FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("POST")]
        public IActionResult POST(Genero genero)
        {
            try
            {
                _context.Genero.Add(genero);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("PUT")]
        public IActionResult PUT(Genero genero)
        {
            try
            {
                var g = _context.Genero.Where(x => x.idGenero == genero.idGenero).FirstOrDefault();
                g.Nombre = genero.Nombre;
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
