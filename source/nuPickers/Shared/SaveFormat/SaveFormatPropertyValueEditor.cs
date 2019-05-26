namespace nuPickers.Shared.SaveFormat
{
    using Umbraco.Core.PropertyEditors;

    /// <summary>
    /// This class exists so as to be able to save xml direclty into the Umbraco xml cache
    /// </summary>
    public class SaveFormatPropertyValueEditor : ConfigurationEditor<SaveFormatConfiguration>
    {
        /// <summary>
        /// reconstruct values from original (default) data value editor
        /// </summary>
        /// <param name="dataValueEditor"></param>
        public SaveFormatPropertyValueEditor(IDataValueEditor dataValueEditor)
        {
        }
    }

    public class SaveFormatConfiguration
    {
        [ConfigurationField("HideLabel", "Hide Label?", "boolean")]
        public bool HideLabel { get; set; }
    }
}