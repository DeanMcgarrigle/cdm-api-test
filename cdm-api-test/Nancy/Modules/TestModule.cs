using Nancy;

namespace cdm_api_test.Nancy.Modules
{
    public class TestModule : NancyModule
    {
        public TestModule()
            : base("/api")
        {
            Get["/test"] = _ =>
            {
                return Response.AsJson("test success!");
            };
        }
    }
}