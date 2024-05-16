using Microsoft.AspNetCore.Builder;

public static class CorsMiddlewareExtensions
{
    public static IApplicationBuilder UseCorsFilter(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CorsFilter>();
    }
}
