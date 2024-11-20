namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration, DatabaseProvider provider)
        {
            services.AddIdentity<User, Role>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
            })
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddDefaultTokenProviders();

            var databaseSettings = configuration.GetSection("DatabaseSettings").Get<DatabaseSettings>();

            // Register DbContext
            services.AddDbContext<ApplicationDbContext>((sp, options) =>
            {
                options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
                switch (provider)
                {
                    case DatabaseProvider.MSSQL:
                        options.UseSqlServer(databaseSettings.ConnectionString.MSSQL);
                        break;
                    case DatabaseProvider.Postgres:
                        options.UseNpgsql(databaseSettings.ConnectionString.Postgres);
                        break;
                    case DatabaseProvider.MySQL:
                        options.UseMySql(databaseSettings.ConnectionString.MySQL, new MySqlServerVersion(new Version(8, 0, 21)));
                        break;
                    //case DatabaseProvider.SQLite://NuGet Package: Microsoft.EntityFrameworkCore.Sqlite
                    //    options.UseSqlite(databaseSettings.ConnectionString.SQLite); 
                    //    break;
                    //case DatabaseProvider.Oracle://NuGet Package: Oracle.EntityFrameworkCore
                    //    options.UseOracle(databaseSettings.ConnectionString.Oracle);
                    //    break;
                    //case DatabaseProvider.InMemory://NuGet Package: Microsoft.EntityFrameworkCore.InMemory
                    //    options.UseInMemoryDatabase("TestDatabase");
                    //    break;
                    default:
                        throw new NotSupportedException($"The database provider {provider} is not supported.");
                }
            });

            return services;
        }
    }
}
