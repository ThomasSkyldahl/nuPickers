using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace nuPickers.Shared
{
    using System.Collections.Generic;
    using System.Linq;
    using Umbraco.Web.Editors;
    using Umbraco.Web.Mvc;

    [PluginController("nuPickers")]
    public class CustomLabelApiController : UmbracoAuthorizedJsonController
    {
        private readonly IMacroService _macroService;

        public CustomLabelApiController(IMacroService macroService)
        {
            _macroService = macroService;
        }

        public IEnumerable<object> GetMacros()
        {
            //using legacy api as no method on Umbraco.Core.Services.MacroSerivce to get all macros
            return _macroService.GetAll()
                        .Select(x => new
                        {
                            name = x.Name,
                            alias = x.Alias
                        });
        }
    }
}
