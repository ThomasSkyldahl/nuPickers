using nuPickers.Shared.DotNetDataSource;
using Umbraco.Core.Composing;

namespace nuPickers.Composing
{
    public static class DataSourceCompositionExtensions {
        public static Composition AddDotNetDataSource<TDataSource>(this Composition composition)
            where TDataSource : IDotNetDataSource
        {
            composition.WithCollectionBuilder<LazyDotNetDataSourceCollectionBuilder>().Add<TDataSource>();
            return composition;
        }

    }
}