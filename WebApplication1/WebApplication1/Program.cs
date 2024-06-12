
using Microsoft.EntityFrameworkCore;
using PetBooK.BL.Config;
using WebApplication1.Models;
using WebApplication1.UnitOfWork;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //////// TO Open The Cors for the other domains:
            /// 1)
            string txt = "";

            // Add services to the container.

            builder.Services.AddControllers();


            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<egydynamicsContext>(
               op => op.UseSqlServer(builder.Configuration.GetConnectionString("egydynamics")));

            /// 2)
            builder.Services.AddCors(option =>
            {
                option.AddPolicy(txt, builder => {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });

            /// For generic repo:
            builder.Services.AddScoped<UnitWork>();
            builder.Services.AddAutoMapper(typeof(AutoMapConfig).Assembly);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            /// 3)
            app.UseCors(txt);

            app.MapControllers();


            app.Run();
        }
    }
}
