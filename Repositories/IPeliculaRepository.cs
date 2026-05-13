using ApiPeliculas.Models;

namespace ApiPeliculas.Repositories
{
    public interface IPeliculaRepository
    {
        List<Pelicula> ObtenerTodas();

        Pelicula? ObtenerPorId(int id);

        void Agregar(Pelicula pelicula);
    }
}