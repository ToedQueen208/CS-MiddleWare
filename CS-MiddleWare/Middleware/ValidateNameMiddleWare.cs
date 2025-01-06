
namespace CS_MiddleWare.Middleware
{
    public class ValidateNameMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            await next.Invoke(context);

        }
    }
}
