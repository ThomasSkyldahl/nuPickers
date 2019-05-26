using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using nuPickers.Shared.DotNetDataSource;

namespace nuPickers.PropertyEditors.DotNetTypeaheadListPicker
{
    using nuPickers.EmbeddedResource;
    using Umbraco.Core.PropertyEditors;

    public class DotNetTypeaheadListPickerPreValueEditor
    {
        [ConfigurationField("dataSource", "Data Source", EmbeddedResource.ROOT_URL + "DotNetDataSource/DotNetDataSourceConfig.html", HideLabel = true)]
        public DotNetDataSourceConfigurationDto DataSource { get; set; } = new DotNetDataSourceConfigurationDto();

        [ConfigurationField("customLabel", "Label Macro", EmbeddedResource.ROOT_URL + "CustomLabel/CustomLabelConfig.html", HideLabel = true)]
        public string CustomLabel { get; set; }

        [ConfigurationField("typeaheadListPicker", "Typeahead List Picker", EmbeddedResource.ROOT_URL + "TypeaheadListPicker/TypeaheadListPickerConfig.html", HideLabel = true)]
        public ConfigurationObject TypeaheadListPicker { get; set; } = new ConfigurationObject();

        [ConfigurationField("listPicker", "List Picker", EmbeddedResource.ROOT_URL + "ListPicker/ListPickerConfig.html", HideLabel = true)]
        public ConfigurationObject ListPicker { get; set; } = new ConfigurationObject();

        [ConfigurationField("relationMapping", "Relation Mapping", EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingConfig.html", HideLabel = true)]
        public string RelationMapping { get; set; }

        [ConfigurationField("saveFormat", "Save Format", EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfig.html")]
        public string SaveFormat { get; set; }
    }

    public class ConfigurationObject
    {
        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }
    }
}