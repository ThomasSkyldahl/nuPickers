using Newtonsoft.Json;

namespace nuPickers.Shared.DotNetDataSource
{
    public class DotNetDataSourcePropertyDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}