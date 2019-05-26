
using Umbraco.Core.Logging;

namespace nuPickers.PropertyEditors
{
    using nuPickers.Shared.SaveFormat;
    using Umbraco.Core.PropertyEditors;

    public abstract class BasePropertyEditor : DataEditor
    {
        protected BasePropertyEditor(ILogger logger) : base(logger)
        {
        }

        protected override IConfigurationEditor  CreateConfigurationEditor()
        {
            return new SaveFormatPropertyValueEditor(base.CreateValueEditor());
        }


    }
}
