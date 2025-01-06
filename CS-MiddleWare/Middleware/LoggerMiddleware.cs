
namespace CS_MiddleWare.Middleware
{
    public class LoggerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            var time = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            var method = context.Request.Method;
            var path = context.Request.Path;
            LogRequest(time, method, path);

            await next.Invoke(context);

            string response = context.Response.StatusCode.ToString();
            LogResponse(response);

        }

        public void LogRequest(string time, string method, string path)
        {
            string filestring = $"\n REQUEST \n Time: {time} \n Method: {method} \n Path:{path}";

            File.AppendAllText("Middleware/ServerLogs.txt", filestring);
            //File.WriteAllText


        }
        public void LogResponse(string response)
        {
            string fileString = "\n RESPONSE \n " + response;

            File.AppendAllText("Middleware/ServerLogs.txt", fileString);
        }
    }
}
