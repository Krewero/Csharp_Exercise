using System.Net;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

Dictionary<int, string> countries = new Dictionary<int, string>()
{
    {1, "United States"},
    {2, "Canada"},
    {3, "United Kingdom"},
    {4, "India"},
    {5, "Japan"}
};

app.UseEndpoints(endpoints =>
{
    IEndpointConventionBuilder endpointConventionBuilder = endpoints.MapGet("/countries", async (HttpContext context) =>
    {
        context.Response.StatusCode = 200;
        foreach (KeyValuePair<int, string> count in countries)
        {
            
            await context.Response.WriteAsync(count.Value);
        }
    });
});

app.UseEndpoints(endpoints =>
{
    IEndpointConventionBuilder endpointConventionBuilder = endpoints.MapGet("/countries/{countryID:int:range(1,100)}", async (context) =>
    {
        int routeValue = Convert.ToInt32(context.Request.RouteValues["countryID"]);
        if (routeValue >= 1 && routeValue <= 5)
        {
            countries.TryGetValue(routeValue, out var result);
            context.Response.StatusCode = 200;
            await context.Response.WriteAsync(result);
        }
        else
        {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsync("No country for this ID");
        }
    });
});

app.Run(async (HttpContext context) =>
{
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync("Waiting for the GET Request...");
});

app.Run();
