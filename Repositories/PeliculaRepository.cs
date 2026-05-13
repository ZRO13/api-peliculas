using ApiPeliculas.Models;

namespace ApiPeliculas.Repositories
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private static List<Pelicula> peliculas = new List<Pelicula>
        {
            new Pelicula
            {
                Id = 1,
                Titulo = "Interstellar",
                Director = "Christopher Nolan",
                Disponible = true
            },

            new Pelicula
            {
                Id = 2,
                Titulo = "Titanic",
                Director = "James Cameron",
                Disponible = true
            },

            new Pelicula
            {
                Id = 3,
                Titulo = "Avatar",
                Director = "James Cameron",
                Disponible = false
            }
        };

        public List<Pelicula> ObtenerTodas()
        {
            return peliculas;
        }

        public Pelicula? ObtenerPorId(int id)
        {
            return peliculas.FirstOrDefault(p => p.Id == id);
        }

        public void Agregar(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }
    }
}