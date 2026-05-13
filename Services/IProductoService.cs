using ApiPeliculas.Models;

namespace ApiPeliculas.Services
{
    public interface IPeliculaService
    {
        List<Pelicula> ObtenerTodas();

        Pelicula? ObtenerPorId(int id);

        void Agregar(Pelicula pelicula);
    }
}