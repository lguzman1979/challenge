using ChallengeAPI.Data;
using ChallengeAPI.Data.DTO;
using ChallengeAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAPI.Controllers
{
    [ApiController]
    [Route("Imagenes")]
    public class ImagenController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ImagenController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GET")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Imagen.ToList());
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
                return Ok(_context.Imagen.Where(x => x.idImagen == id).FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("POST")]
        public IActionResult POST(Imagen imagen)
        {
            try
            {
                _context.Imagen.Add(imagen);
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
