using Microsoft.EntityFrameworkCore;
using WebApi.Repository.Context;

namespace WebApi
{
    public class Program
    {
        private IConfiguration _configuration;

        public Program(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            IConfiguration? configuration = builder.Services.BuildServiceProvider()
                .GetRequiredService<IConfiguration>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            var app = builder.Build();

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