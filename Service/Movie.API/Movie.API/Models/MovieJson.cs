using Newtonsoft.Json;
using System.Collections.Generic;

namespace Movie.API.Models
{
    public class MovieJson
    {
        [JsonProperty("movies")]
        public IEnumerable<MovieEntity> Movies { get; set; }
    }
}
