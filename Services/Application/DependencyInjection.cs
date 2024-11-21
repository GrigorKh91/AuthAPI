using Application.Mappings;

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
            services.AddScoped<UserManagerHelper>();

            services.AddAutoMapper(typeof(UserProfile).Assembly);
            services.AddAutoMapper(typeof(User).Assembly);

            return services;
        }
    }
}
