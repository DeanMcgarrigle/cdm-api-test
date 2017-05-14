using cdm_api_test.Nancy;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Extensions;
using Nancy.Owin;
using Owin;

namespace cdm_api_test
{
    public class startup
    {
        public void configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.UseNancy(NancyConfig);
            app.UseStageMarker(PipelineStage.MapHandler);
        }
        private static void NancyConfig(NancyOptions nancyOptions)
        {
            nancyOptions.Bootstrapper = new Bootstrapper();
        }
    }
}