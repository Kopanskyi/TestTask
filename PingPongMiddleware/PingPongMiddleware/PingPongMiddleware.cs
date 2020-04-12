using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PingPongMiddleware
{
    public class PingPongMiddleware
    {
        private readonly RequestDelegate _next;

        public PingPongMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var responseVal = "TestTask";
            context.Request.Headers.TryGetValue("TestTask", out var value);

            if (value == "Ping")
            {
                if (context.Response.Headers.TryGetValue("TestTask", out var respValue))
                {
                    context.Response.Headers.Remove("TestTask");
                }

                context.Response.Headers.Add("TestTask", "Pong");
                responseVal = "Pong";
            }

            await context.Response.WriteAsync(responseVal);
        }
    }
}
