using ApiPeliculas.Models;
using ApiPeliculas.Repositories;

namespace ApiPeliculas.Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculaRepository _repository;

        public PeliculaService(IPeliculaRepository repository)
        {
            _repository = repository;
        }

        public List<Pelicula> ObtenerTodas()
        {
            return _repository.ObtenerTodas();
        }

        public Pelicula? ObtenerPorId(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public void Agregar(Pelicula pelicula)
        {
            _repository.Agregar(pelicula);
        }
    }
}