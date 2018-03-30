using Newtonsoft.Json;

namespace BetaSeries.API.Model
{
    public class Note
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mean")]
        public decimal Mean { get; set; }

        [JsonProperty("user")]
        public int User { get; set; }
    }
}