using Newtonsoft.Json;
using System.Collections.Generic;

namespace Movie.API.Models
{
    public class MovieEntity
    {
        public string Language { get; set; }

        public string Location { get; set; }

        public string Plot { get; set; }

        public string Poster { get; set; }

        public IEnumerable<string> SoundEffects { get; set; }

        public IEnumerable<string> Stills { get; set; }

        public string Title { get; set; }

        [JsonProperty("imdbID")]
        public string IMDBID { get; set; }

        [JsonProperty("listingType")]
        public string ListingType { get; set; }

        [JsonProperty("imdbRating")]
        public string IMDBRating { get; set; }
    }
}
