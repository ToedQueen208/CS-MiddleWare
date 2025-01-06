
using CS_MiddleWare.Middleware;
using CS_MiddleWare.Models;
using CS_MiddleWare.Services;
using Microsoft.EntityFrameworkCore;

namespace CS_MiddleWare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.AddScoped<AdventurersModel>();
            builder.Services.AddScoped<AdventurersService>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<MyAdventureDBContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddTransient<LoggerMiddleware>();
            builder.Services.AddTransient<ValidateNameMiddleWare>();

            var app = builder.Build();

            app.UseMiddleware<LoggerMiddleware>();
            app.UseMiddleware<ValidateNameMiddleWare>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
