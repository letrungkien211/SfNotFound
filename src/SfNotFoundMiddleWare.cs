using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SfNotFound
{
    /// <summary>
    /// Refer to https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-reverseproxy  Keyword: X-ServiceFabric
    /// </summary>
    internal class SfNotFoundMiddleWare
    {
        private readonly RequestDelegate _next;

        public SfNotFoundMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await _next(httpContext);
            if (httpContext.Response?.StatusCode == 404)
            {
                httpContext.Response.Headers["X-ServiceFabric"] = "ResourceNotFound";
            }
        }
    }
}
