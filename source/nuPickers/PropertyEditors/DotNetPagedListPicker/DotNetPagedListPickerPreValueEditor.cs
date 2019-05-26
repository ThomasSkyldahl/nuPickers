namespace nuPickers.PropertyEditors.DotNetPagedListPicker
{
    using Umbraco.Core.PropertyEditors;
    using nuPickers.EmbeddedResource;

    public class DotNetPagedListPickerPreValueEditor
    {
        [ConfigurationField("dataSource", "", EmbeddedResource.ROOT_URL + "DotNetDataSource/DotNetDataSourceConfig.html", HideLabel = true)]
        public string DataSource { get; set; }

        [ConfigurationField("customLabel", "", EmbeddedResource.ROOT_URL + "CustomLabel/CustomLabelConfig.html", HideLabel = true)]
        public string CustomLabel { get; set; }

        [ConfigurationField("pagedListPicker", "", EmbeddedResource.ROOT_URL + "PagedListPicker/PagedListPickerConfig.html", HideLabel = true)]
        public string PagedListPicker { get; set; }

        [ConfigurationField("listPicker", "", EmbeddedResource.ROOT_URL + "ListPicker/ListPickerConfig.html", HideLabel = true)]
        public string ListPicker { get; set; }

        [ConfigurationField("relationMapping", "", EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingConfig.html", HideLabel = true)]
        public string RelationMapping { get; set; }

        [ConfigurationField("saveFormat", "Save Format", EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfig.html")]
        public string SaveFormat { get; set; }
    }
}