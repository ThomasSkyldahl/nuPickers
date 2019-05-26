using System;

namespace nuPickers
{
    using nuPickers.PropertyEditors;
    using System.Linq;
    using Umbraco.Core.Models.PublishedContent;
    using Umbraco.Core.PropertyEditors;

    public class PickerPropertyValueConverter : PropertyValueConverterBase
    {
        /// <summary>
        /// This is a generic converter for all nuPicker Picker PropertyEditors
        /// </summary>
        /// <param name="publishedPropertyType"></param>
        /// <returns></returns>
        public override bool IsConverter(PublishedPropertyType publishedPropertyType)
        {
            return PickerPropertyValueConverter.IsPicker(publishedPropertyType.EditorAlias);
        }

        /// <summary>
        /// Helper to check to see if the supplied propertyEditorAlias corresponds with a nuPicker Picker
        /// </summary>
        /// <param name="propertyEditorAlias"></param>
        /// <returns></returns>
        public static bool IsPicker(string propertyEditorAlias)
        {
            return new [] { 
                        PropertyEditorConstants.DotNetCheckBoxPickerAlias,
                        PropertyEditorConstants.DotNetDropDownPickerAlias,
                        PropertyEditorConstants.DotNetPagedListPickerAlias,
                        PropertyEditorConstants.DotNetPrefetchListPickerAlias,
                        PropertyEditorConstants.DotNetRadioButtonPickerAlias,
                        PropertyEditorConstants.DotNetTypeaheadListPickerAlias,
                        PropertyEditorConstants.EnumCheckBoxPickerAlias,
                        PropertyEditorConstants.EnumDropDownPickerAlias,
                        PropertyEditorConstants.EnumPrefetchListPickerAlias,
                        PropertyEditorConstants.EnumRadioButtonPickerAlias,
                        PropertyEditorConstants.JsonCheckBoxPickerAlias,
                        PropertyEditorConstants.JsonDropDownPickerAlias,
                        PropertyEditorConstants.JsonPagedListPickerAlias,
                        PropertyEditorConstants.JsonPrefetchListPickerAlias,
                        PropertyEditorConstants.JsonRadioButtonPickerAlias,
                        PropertyEditorConstants.JsonTypeaheadListPickerAlias,
                        PropertyEditorConstants.LuceneCheckBoxPickerAlias,
                        PropertyEditorConstants.LuceneDropDownPickerAlias,
                        PropertyEditorConstants.LucenePagedListPickerAlias,
                        PropertyEditorConstants.LucenePrefetchListPickerAlias,
                        PropertyEditorConstants.LuceneRadioButtonPickerAlias,
                        PropertyEditorConstants.LuceneTypeaheadListPickerAlias,
                        PropertyEditorConstants.SqlCheckBoxPickerAlias,
                        PropertyEditorConstants.SqlDropDownPickerAlias,
                        PropertyEditorConstants.SqlPagedListPickerAlias,
                        PropertyEditorConstants.SqlPrefetchListPickerAlias,
                        PropertyEditorConstants.SqlRadioButtonPickerAlias,
                        PropertyEditorConstants.SqlTypeaheadListPickerAlias
                    }
                 .Contains(propertyEditorAlias);
        }

        public override PropertyCacheLevel GetPropertyCacheLevel(PublishedPropertyType propertyType)
        {
            return PropertyCacheLevel.Element;
        }

        public override Type GetPropertyValueType(PublishedPropertyType propertyType)
        {
            return typeof(Picker);
        }

        public override object ConvertSourceToIntermediate(IPublishedElement owner, PublishedPropertyType propertyType, object source,
            bool preview)
        {
            int contextId = -1;
            int parentId = -1;
            IPublishedContent assignedContentItem;

            if (owner is IPublishedContent publishedContent)
            {
                assignedContentItem = publishedContent;
            }
            else
            {
                try
                {
                    assignedContentItem = Umbraco.Web.Composing.Current.UmbracoHelper.AssignedContentItem;
                }
                catch
                {
                    assignedContentItem = null;
                }
            }

            if (assignedContentItem != null)
            {
                contextId = assignedContentItem.Id;

                if (assignedContentItem.Parent != null)
                {
                    parentId = assignedContentItem.Parent.Id;
                }
            }

            return new Picker(
                contextId, 
                parentId,
                propertyType.Alias, 
                propertyType.DataType.Id, 
                propertyType.EditorAlias, source);
        }

        public override object ConvertIntermediateToObject(IPublishedElement owner, PublishedPropertyType propertyType,
            PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            return inter as string;
        }
    }
}