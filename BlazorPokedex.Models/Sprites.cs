using Newtonsoft.Json;

namespace BlazorPokedex.Models
{
    public class Sprites
    {
        [JsonProperty("front_default")]
        public string FronDefault { get; set; }

        [JsonProperty("back_default")]
        public string Back { get; set; }
    }
}