using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace nuPickers.Shared.RelationDataSource
{
    using System.Collections.Generic;
    using System.Linq;
    using Umbraco.Web.Editors;
    using Umbraco.Web.Mvc;

    [PluginController("nuPickers")]
    public class RelationDataSourceApiController : UmbracoAuthorizedJsonController
    {
        private readonly IRelationService _relationService;

        public RelationDataSourceApiController(IRelationService relationService)
        {
            _relationService = relationService;
        }

        public IEnumerable<object> GetRelationTypes()
        {
            return _relationService.GetAllRelationTypes()
                        .OrderBy(x => x.Name)
                        .Select(x => new
                        {
                            key = x.Alias,
                            label = x.Name,
                            biDirectional = x.IsBidirectional
                        });
        }
    }
}