﻿namespace nuPickers.Shared.LuceneDataSource
{
    using System.Collections.Generic;
    using System.Linq;
    using Umbraco.Web.Editors;
    using Umbraco.Web.Mvc;

    [PluginController("nuPickers")]
    public class LuceneDataSourceApiController : UmbracoAuthorizedJsonController
    {
        public IEnumerable<object> GetExamineSearchers()
        {
            return Examine.ExamineManager.Instance.RegisteredSearchers.Select(x => x.Name);            
        }
    }
}