namespace ASPCoreMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Required to register MVC Controllers and Views
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapDefaultControllerRoute();
            //START ---- FOR ROUTNING ----START
            //Activate when not implementing MVC model
            //Hello World ; Simple MIddleware route
            //app.MapGet("/", () => "Hello World!");

            //Activate when not implementing MVC model
            //One Middleware statement
            //app.Run(async(context) =>
            //{
            //    await context.Response.WriteAsync("Welcome to ASP.NET Core 8");
            //});

            //Activate when not implementing MVC model, and
            //Use method is used to excute multiple middleware in order 
            //First Middleware
            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("Middleware 1: Welcome to ASP.NET Core 8");
            //    await next(context); 
            //});

            //Activate when not implementing MVC model, and
            //Run method is used to run a single middleware
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Middleware 2: The second context after running the first middleware");
            //});
            //END ---- FOR ROUTNING ----END

            app.Run(); //To Run App.
        }
    }
}
