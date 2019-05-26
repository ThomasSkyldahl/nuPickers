using nuPickers.Shared.DotNetDataSource;
using Umbraco.Core.Composing;

namespace nuPickers.Composing
{
    internal class LazyDotNetDataSourceCollectionBuilder : LazyCollectionBuilderBase<LazyDotNetDataSourceCollectionBuilder, DotNetDataSourceCollectionBuilder, IDotNetDataSource>
    {
        protected override LazyDotNetDataSourceCollectionBuilder This => this;
    }
}