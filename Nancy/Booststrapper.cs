using Nancy;
using Nancy.Bootstrapper;
using Nancy.Responses.Negotiation;
using Nancy.TinyIoc;

namespace cdm_api_test.Nancy
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {

        }

        protected override NancyInternalConfiguration InternalConfiguration
        {
            get
            {
                return NancyInternalConfiguration.WithOverrides(x => x.ResponseProcessors = new[]
                {
                    typeof(ViewProcessor),
                    typeof(JsonProcessor),
                    typeof(XmlProcessor)
                });
            }
        }
    }
}