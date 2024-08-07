namespace ASPCoreMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            //Hello World ; Simple MIddleware route
            //app.MapGet("/", () => "Hello World!");

            //One Middleware statement
            //app.Run(async(context) =>
            //{
            //    await context.Response.WriteAsync("Welcome to ASP.NET Core 8");
            //});
            //Use method is used to excute multiple middleware in order
            app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync("Welcome to ASP.NET Core 8");
                await next(context); 
            });

            //Run method is used to run a single middleware
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("The second context after running the first middleware");
            });

            app.Run();
        }
    }
}
