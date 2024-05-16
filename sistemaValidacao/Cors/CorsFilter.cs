public class CorsFilter
{
    private readonly RequestDelegate _next;

    public CorsFilter(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        context.Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:8080");
        context.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
        context.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");

        // Para lidar com a solicitação OPTIONS
        if (context.Request.Method == "OPTIONS")
        {
            context.Response.StatusCode = StatusCodes.Status200OK;
            await context.Response.CompleteAsync();
            return;
        }

        await _next(context);
    }
}
