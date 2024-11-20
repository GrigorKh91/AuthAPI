namespace Auth.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.Configure<JwtOptions>(configuration.GetSection("JwtOptions"));
            services.AddJWTAuthentication(configuration);




            return services;
        }

        public static WebApplication UseApiServices(this WebApplication app)
        {
            //app.UseExceptionHandler(options => { });
            //app.UseHealthChecks("/health",
            //    new HealthCheckOptions
            //    {
            //        ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            //    });

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }


        private static void AddJWTAuthentication(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
          .AddJwtBearer(options =>
          {
              var jwtOptions = configuration.GetSection("JwtOptions");
              options.TokenValidationParameters = new TokenValidationParameters
              {
                  ValidateIssuer = true,
                  ValidateAudience = true,
                  ValidateLifetime = true,
                  ValidateIssuerSigningKey = true,
                  ValidIssuer = jwtOptions["Issuer"],
                  ValidAudience = jwtOptions["Audience"],
                  IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions["Secret"]))
              };
          });
        }

    }
}
