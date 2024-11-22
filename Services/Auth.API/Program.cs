namespace Auth.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                                    .AddApiServices(builder.Configuration)
                                    .AddApplicationServices(builder.Configuration)
                                    .AddInfrastructureServices(builder.Configuration, DatabaseProvider.MSSQL);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseApiServices();

            app.Run();
        }
    }
}
