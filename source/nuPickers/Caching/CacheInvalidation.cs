using System;
using System.Collections.Generic;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Services.Implement;
using IComponent = Umbraco.Core.Composing.IComponent;

namespace nuPickers.Caching
{
    using Umbraco.Core.Events;
    using Umbraco.Core.Services;
    using Umbraco.Core.Models;

    public class CacheInvalidationComposer : IUserComposer {
        public void Compose(Composition composition)
        {
            composition.Components().Append<CacheInvalidationComponent>();
        }
    }

    public class CacheInvalidationComponent : IComponent
    {
        private void ContentService_Saved(IContentService sender, SaveEventArgs<IContent> e)
        {
            e.SavedEntities.ForEach(x => Cache.Instance.Remove(y => y.StartsWith(CacheConstants.PickedKeysPrefix + x.Id.ToString())));
        }

        private void ContentService_Deleted(IContentService sender, DeleteEventArgs<IContent> e)
        {
            e.DeletedEntities.ForEach(x => Cache.Instance.Remove(y => y.StartsWith(CacheConstants.PickedKeysPrefix + x.Id.ToString())));
        }

        private void DataTypeService_Saved(IDataTypeService sender, SaveEventArgs<IDataType> e)
        {
            e.SavedEntities.ForEach(x => Cache.Instance.Remove(CacheConstants.DataTypePreValuesPrefix + x.Id.ToString()));
        }

        private void DataTypeService_Deleted(IDataTypeService sender, DeleteEventArgs<IDataType> e)
        {
            e.DeletedEntities.ForEach(x => Cache.Instance.Remove(CacheConstants.DataTypePreValuesPrefix + x.Id.ToString()));
        }

        public void Initialize()
        {
            ContentService.Saved += this.ContentService_Saved;
            ContentService.Deleted += this.ContentService_Deleted;

            DataTypeService.Saved += this.DataTypeService_Saved;
            DataTypeService.Deleted += this.DataTypeService_Deleted;
        }

        public void Terminate()
        {
            ContentService.Saved -= this.ContentService_Saved;
            ContentService.Deleted -= this.ContentService_Deleted;

            DataTypeService.Saved -= this.DataTypeService_Saved;
            DataTypeService.Deleted -= this.DataTypeService_Deleted;
        }
    }

    public static class CacheInvalidationExtensions
    {
        public static void ForEach<TElement>(this IEnumerable<TElement> elements, Action<TElement> action)
        {
            foreach (var element in elements)
            {
                action(element);
            }
        }
    }
}