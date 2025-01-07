
using System.Text.Json;

namespace CS_MiddleWare.Middleware
{
    public class ValidateNameMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            if (context.Request.Method == "POST" && context.Request.Path == "/Adventurers")
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Response.WriteAsync("This character name is forbidden.");
                return;
                //if (isValid(context))
                //    await next.Invoke(context);
                //else
                //{
                //    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                //    context.Response.WriteAsync("This character name is forbidden.");
                //    return;
                //}
            }
            else
            {
                await next.Invoke(context);
            }



        }

        private bool isValid(HttpContext context)
        {
            context.Request.EnableBuffering();

            var reader = new StreamReader(context.Request.Body, leaveOpen: true);

            var postData = reader.ReadToEnd();
            JsonDocument json = JsonDocument.Parse(postData);
            JsonElement root = json.RootElement;
            string name = root.GetProperty("name").ToString();
            context.Request.Body.Position = 0;
            if (name == "pomeranian" || name == "bruno" || name == "voldemort" || name == "rickroll")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
