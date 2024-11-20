using Application.Mappings;
using Domain.Options;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
                                                                                                   IConfiguration configuration)
        {
            services.AddScoped<IApiAuthenticationService, ApiAuthenticationService>();
            services.AddScoped<IPasswordService, PasswordService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJwtService, JwtService>();

            services.AddAutoMapper(typeof(User).Assembly);

            return services;
        }
    }
}
