using Umbraco.Core.Composing;
using Umbraco.Web;

namespace nuPickers.EmbeddedResource
{
    using ClientDependency.Core;
    using System.Web.Mvc;
    using System.Web.Routing;
    using Umbraco.Core;

    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class EmbeddedResourceComposer : IComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<EmbeddedResourceComponent>();
        }
    }

    public class EmbeddedResourceComponent : IComponent
    {
        public void Initialize()
        {
            RouteTable
               .Routes
               .MapRoute(
                    name: "nuPickersShared",
                    url:  EmbeddedResource.ROOT_URL.TrimStart("~/") + "{folder}/{file}",
                    defaults: new
                    {
                        controller = "EmbeddedResource",
                        action = "GetSharedResource"
                    },
                    namespaces: new[] { "nuPickers.EmbeddedResource" });

            FileWriters.AddWriterForExtension(EmbeddedResource.FILE_EXTENSION, new EmbeddedResourceVirtualFileWriter());
        }

        public void Terminate()
        {
        }
    }
}
