using Movie.API.Models;
using Movie.API.Models.Filter;
using System.Collections.Generic;

namespace Movie.API.Services
{
    public interface IMovieRepository
    {
        IEnumerable<MovieEntity> GetMovies(MovieFilter filter);

        MovieEntity GetMovieById(string id);
    }
}
