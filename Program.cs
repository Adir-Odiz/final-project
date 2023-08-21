using WebApplication1;

namespace final_project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var startup = new Startup(builder.Configuration);

            startup.ConfigureServices(builder.Services);

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();


            startup.Configure(app, builder.Environment);

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}