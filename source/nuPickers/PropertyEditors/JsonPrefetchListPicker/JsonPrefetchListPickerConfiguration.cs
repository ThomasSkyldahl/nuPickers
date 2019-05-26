﻿namespace nuPickers.PropertyEditors.JsonPrefetchListPicker
{
    using nuPickers.EmbeddedResource;
    using Umbraco.Core.PropertyEditors;

    public class JsonPrefetchListPickerConfiguration
    {
        [ConfigurationField("dataSource", "", EmbeddedResource.ROOT_URL + "JsonDataSource/JsonDataSourceConfig.html", HideLabel = true)]
        public string DataSource { get; set; }

        [ConfigurationField("customLabel", "", EmbeddedResource.ROOT_URL + "CustomLabel/CustomLabelConfig.html", HideLabel = true)]
        public string CustomLabel { get; set; }

        [ConfigurationField("prefetchListPicker", "", EmbeddedResource.ROOT_URL + "PrefetchListPicker/PrefetchListPickerConfig.html", HideLabel = true)]
        public string PrefetchListPicker { get; set; }

        [ConfigurationField("listPicker", "", EmbeddedResource.ROOT_URL + "ListPicker/ListPickerConfig.html", HideLabel = true)]
        public string ListPicker { get; set; }

        [ConfigurationField("relationMapping", "", EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingConfig.html", HideLabel = true)]
        public string RelationMapping { get; set; }

        [ConfigurationField("saveFormat", "Save Format", EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfig.html")]
        public string SaveFormat { get; set; }
    }
}