using ApiPeliculas.Models;

namespace ApiPeliculas.Repositories
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private static List<Pelicula> peliculas = new List<Pelicula>{
          new Pelicula
            {
                Id = 1,
                Titulo = "El Código Enigma",
                Director = "Morten Tyldum",
                Disponible = true
            },

            new Pelicula
            {
                Id = 2,
                Titulo = "Ex Machina",
                Director = "Alex Garland",
                Disponible = true
            },

            new Pelicula
            {
                Id = 3,
                Titulo = "Inteligencia Artificial",
                Director = "Steven Spielberg",
                Disponible = false
            },

            new Pelicula
            {
                Id = 4,
                Titulo = "Her",
                Director = "Spike Jonze",
                Disponible = true
            },

            new Pelicula
            {
                Id = 5,
                Titulo = "The Social Network",
                Director = "David Fincher",
                Disponible = true
            },

            new Pelicula
            {
                Id = 6,
                Titulo = "Minority Report",
                Director = "Steven Spielberg",
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