using System.Collections.Generic;
using Newtonsoft.Json;

namespace nuPickers.Shared.DotNetDataSource
{
    public class DotNetDataSourceConfigurationDto
    {
        [JsonProperty("assemblyName")]
        public string AssemblyName { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("apiController")]
        public string ApiController { get; set; }

        [JsonProperty("properties")]
        public IEnumerable<DotNetDataSourcePropertyDto> Properties { get; set; }
    }
}