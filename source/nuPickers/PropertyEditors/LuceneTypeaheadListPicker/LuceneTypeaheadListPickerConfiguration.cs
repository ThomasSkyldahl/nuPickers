using Umbraco.Core.PropertyEditors;

namespace nuPickers.PropertyEditors.LuceneTypeaheadListPicker
{
  public class LuceneTypeaheadListPickerConfiguration
    {
        [ConfigurationField("dataSource", "", EmbeddedResource.EmbeddedResource.ROOT_URL + "LuceneDataSource/LuceneDataSourceConfig.html", HideLabel = true)]
        public string DataSource { get; set; }

        [ConfigurationField("customLabel", "Label Macro", EmbeddedResource.EmbeddedResource.ROOT_URL + "CustomLabel/CustomLabelConfig.html", HideLabel = true)]
        public string CustomLabel { get; set; }

        [ConfigurationField("typeaheadListPicker", "", EmbeddedResource.EmbeddedResource.ROOT_URL + "TypeaheadListPicker/TypeaheadListPickerConfig.html", HideLabel = true)]
        public string TypeaheadListPicker { get; set; }

        [ConfigurationField("listPicker", "", EmbeddedResource.EmbeddedResource.ROOT_URL + "ListPicker/ListPickerConfig.html", HideLabel = true)]
        public string ListPicker { get; set; }

        [ConfigurationField("relationMapping", "", EmbeddedResource.EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingConfig.html", HideLabel = true)]
        public string RelationMapping { get; set; }

        [ConfigurationField("saveFormat", "Save Format", EmbeddedResource.EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfig.html")]
        public string SaveFormat { get; set; }
    }
}