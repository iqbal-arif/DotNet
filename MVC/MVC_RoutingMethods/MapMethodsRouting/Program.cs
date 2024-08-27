namespace MapMethodsRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            //Map Method itself is used for all MapGet,MapPost,MapPut, and MapDelete
            //app.Map("/Home", () => "Map Methods: Hello World!");
            //Single line Method is used when one action is required
            //app.MapGet("/Home", () => "Map Method - Get: Hello World!");
            //app.MapPost("/Home", () => "Map Method - Post: Hello World!");
            //app.MapPut("/Home", () => "Map Method - Put: Hello World!");
            //app.MapDelete("/Home", () => "Map Method - Delete: Hello World!");


            //ENDPOINTS METHODS ROUTING
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async (context) =>
                {
                    await context.Response.WriteAsync("This is HomePage at Get Method...");
                });
            });
            app.Run();
        }
    }
}
