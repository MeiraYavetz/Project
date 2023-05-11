using Context;
using Repository;
using Service.AlgorithmAndFunctions;
using Service;

namespace HMOProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Enabled Cors
            var MyAllowSpecificOrigins = "http://localhost:3000";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins(MyAllowSpecificOrigins)
                                      .AllowAnyHeader()
                                      .AllowAnyMethod();
                                  }
                                  );
            });

            // Add Service to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IAlgorithm, Algorithm>();
            builder.Services.AddDbContext<IContext, HmoMembersContext>();
            builder.Services.AddService();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);

            app.MapControllers();

            app.Run();
        }
    }
}