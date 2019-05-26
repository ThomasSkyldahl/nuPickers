
using Umbraco.Core.Logging;

namespace nuPickers.PropertyEditors
{
    using Umbraco.Core.PropertyEditors;

    public abstract class BasePropertyEditor<TConfiguration> : DataEditor where TConfiguration: IConfigurationEditor, new()
    {
        protected BasePropertyEditor(ILogger logger) : base(logger)
        {
        }

        protected override IConfigurationEditor  CreateConfigurationEditor()
        {
            return new TConfiguration();
        }
    }
}
