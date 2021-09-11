using Movie.API.Models;
using Movie.API.Models.Filter;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Movie.API.Services
{
    public class MovieRepository : IMovieRepository
    {
        private const string MOVIE_JSON_PATH = "Resources/json-movies.json";

        public IEnumerable<MovieEntity> GetMovies(MovieFilter filter)
        {
            var movieJsonSerializedData = System.IO.File.ReadAllText(MOVIE_JSON_PATH);

            if (!string.IsNullOrEmpty(movieJsonSerializedData))
            {
                var movieJsonDeserializedData = JsonConvert.DeserializeObject<MovieJson>(movieJsonSerializedData);
                var movies = movieJsonDeserializedData?.Movies != null && movieJsonDeserializedData.Movies.Any() ? movieJsonDeserializedData.Movies : new List<MovieEntity>();
                ApplyFilter(filter, ref movies);
                return movies;
            }

            else
                return new List<MovieEntity>();
        }

        private void ApplyFilter(MovieFilter filter, ref IEnumerable<MovieEntity> movies)
        {
            if (!string.IsNullOrEmpty(filter?.Language))
            {
                movies = movies.Where(x => x.Language.ToLower().Contains(filter.Language.ToLower()));
            }

            if (!string.IsNullOrEmpty(filter?.Location))
            {
                movies = movies.Where(x => x.Location.ToLower().Contains(filter.Location.ToLower()));
            }

            if (!string.IsNullOrEmpty(filter?.Title))
            {
                movies = movies.Where(x => x.Title.ToLower().Contains(filter.Title.ToLower()));
            }
        }

        public MovieEntity GetMovieById(string id)
        {
            return GetMovies(null)?.FirstOrDefault(x => x.IMDBID == id);
        }
    }
}
