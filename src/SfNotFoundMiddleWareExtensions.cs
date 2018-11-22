using Microsoft.AspNetCore.Builder;

namespace SfNotFound
{
    /// <summary>
    /// Extension method used to add the middleware to the HTTP request pipeline.
    /// </summary>
    public static class SfNotFoundMiddleWareExtensions
    {
        /// <summary>
        /// Use Sf Not Found MiddleWare
        /// Refer to https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-reverseproxy  Keyword: X-ServiceFabric
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseSfNotFoundMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SfNotFoundMiddleWare>();
        }
    }
}
