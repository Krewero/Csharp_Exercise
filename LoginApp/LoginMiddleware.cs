using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Threading.Tasks;

public class LoginMiddleware
{
    private readonly RequestDelegate _next;

    public LoginMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        if(context.Request.Method == "POST" && context.Request.Path == "/")
        {
            string email = null;
            string password = null;

            StreamReader reader = new StreamReader(context.Request.Body);
            string body = await reader.ReadToEndAsync();

            Dictionary<string, StringValues> queryDict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);

            if(queryDict.ContainsKey("email"))
            {
                email = Convert.ToString(queryDict["email"]);
            }
            else
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Invalid input as email");
            }

            if(queryDict.ContainsKey("password"))
            {
                password = Convert.ToString(queryDict["password"]);
            }
            else
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Invalid input as password");
            }

            if(email != null && password != null)

            {
                if(email == "admin@example.com" && password == "admin1234")
                {
                    context.Response.StatusCode = 200;
                    await context.Response.WriteAsync("Valid login");
                }
                else
                {
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync("Invalid Login, please try again");
                }
            }
        }
        else
        {
            await context.Response.WriteAsync("Waiting for the POST request...");
        }
    }
}

public static class ExtensionMiddleware
{
    public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<LoginMiddleware>();
    }
}