using nuPickers.Shared.RelationMapping;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace nuPickers.EmbeddedResource
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class EmbeddedResourceComposer : IComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<RelationMappingApiController>();
            composition.Register<EmbeddedResourceController>();
            composition.Components().Append<EmbeddedResourceComponent>();
        }
    }
}