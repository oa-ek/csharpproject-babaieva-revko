using MedicalCenter.Core.Context;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MedicalCenter.API
{

    public class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowBlazorClient", builder =>
                {
                    builder.WithOrigins("https://localhost:7035")
                           .AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowCredentials();
                });
            });


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Medical Center", Version = "v1" });
            });
            builder.Services.AddDbContext<ProjectContext>(options =>
            {

                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
                    , options => options.EnableRetryOnFailure());
            });
            builder.Services.AddRouting(options => options.LowercaseUrls = true);

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            var app = builder.Build();
            app.UseCors("AllowBlazorClient");

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