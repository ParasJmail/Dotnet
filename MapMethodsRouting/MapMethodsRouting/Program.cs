var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints?.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is home page -> Get");
    });
    
    endpoints?.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is home page -> Post");
    });

    endpoints?.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is home page -> Put");
    });

    
    endpoints?.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is home page -> Delete");
    });

    

});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page not found");
});
//This is new text
//app.Map("/home", () => "Hello World!");
//app.MapGet("/home", () => "Hello World! - Get");
//app.MapPost("/home", () => "Hello World! - Post");
//app.MapPut("/home", () => "Hello World! - Put");
//app.MapDelete("/home", () => "Hello World! - Delete");

app.Run();
