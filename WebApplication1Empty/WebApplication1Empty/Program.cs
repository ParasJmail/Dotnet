var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


//Attribute Based Routing
app.MapControllers();

//Convention Based Routing
//app.MapDefaultControllerRoute();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=About}/{id?}"
//    );

//app.MapGet("/", () => "Hello World!");

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Welcome To Paras");
//});

//app.Use(async (context,next) =>
//{
//    await context.Response.WriteAsync("Welcome To Paras \n");
//    await next();
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Welcome To Paras2 \n");
//});



app.Run();
