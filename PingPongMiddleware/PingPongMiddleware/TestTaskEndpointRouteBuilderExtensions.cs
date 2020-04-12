using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace PingPongMiddleware
{
    public static class TestTaskEndpointRouteBuilderExtensions
    {
        public static IEndpointConventionBuilder MapTestTask(this IEndpointRouteBuilder endpoints, string pattern)
        {
            var pipeline = endpoints.CreateApplicationBuilder()
                .UseMiddleware<PingPongMiddleware>()
                .Build();

            return endpoints.Map(pattern, pipeline);
        }
    }
}
