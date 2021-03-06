﻿namespace nuPickers.PropertyEditors.JsonDropDownPicker
{
    using nuPickers.EmbeddedResource;
    using Umbraco.Core.PropertyEditors;

    public class JsonDropDownPickerConfiguration
    {
        [ConfigurationField("dataSource", "", EmbeddedResource.ROOT_URL + "JsonDataSource/JsonDataSourceConfig.html", HideLabel = true)]
        public string DataSource { get; set; }

        [ConfigurationField("relationMapping", "", EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingConfig.html", HideLabel = true)]
        public string RelationMapping { get; set; }

        [ConfigurationField("saveFormat", "Save Format", EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfig.html")]
        public string SaveFormat { get; set; }
    }
}