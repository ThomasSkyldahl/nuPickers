using System.Collections.Generic;
using nuPickers.Shared.DotNetDataSource;
using Umbraco.Core.Composing;

namespace nuPickers.Composing
{
    internal class DotNetDataSourceCollectionBuilder : BuilderCollectionBase<IDotNetDataSource>
    {
        public DotNetDataSourceCollectionBuilder(IEnumerable<IDotNetDataSource> items) : base(items)
        {
        }
    }
}