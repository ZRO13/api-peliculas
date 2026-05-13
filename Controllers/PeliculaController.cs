using Microsoft.AspNetCore.Mvc;
using ApiPeliculas.Models;
using ApiPeliculas.Services;

namespace ApiPeliculas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculasController : ControllerBase
    {
        private readonly IPeliculaService _service;

        public PeliculasController(IPeliculaService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Pelicula>> Get()
        {
            return Ok(_service.ObtenerTodas());
        }

        [HttpGet("{id}")]
        public ActionResult<Pelicula> GetById(int id)
        {
            var pelicula = _service.ObtenerPorId(id);

            if (pelicula == null)
            {
                return NotFound("Película no encontrada");
            }

            return Ok(pelicula);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Pelicula pelicula)
        {
            _service.Agregar(pelicula);

            return Ok(new
            {
                mensaje = "Película agregada correctamente",
                data = pelicula
            });
        }
    }
}