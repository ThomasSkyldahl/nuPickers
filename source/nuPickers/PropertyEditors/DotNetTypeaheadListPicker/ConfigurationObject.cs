using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace nuPickers.PropertyEditors.DotNetTypeaheadListPicker
{
    public class ConfigurationObject
    {
        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }
    }
}